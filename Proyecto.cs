using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Formularios_lpms
{
    /// <summary>
    /// Estructura para almacenar los datos de un Pokémon en memoria.
    /// </summary>
    public struct Pokemon
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public string Habilidad { get; set; }
        public bool Activo { get; set; } // Para el borrado lógico
    }

    public partial class Proyecto : Form
    {
        // --- Campos de la Clase ---

        /// <summary>
        /// Cadena de conexión a la base de datos MySQL.
        /// </summary>
        private string connectionString = "Server=localhost;Database=pokedex_db;Uid=root;Pwd=Cronos12345;";

        // --- Constructor ---

        /// <summary>
        /// Constructor principal del formulario.
        /// </summary>
        public Proyecto()
        {
            InitializeComponent();
        }

        // --- Eventos del Formulario ---

        /// <summary>
        /// Se ejecuta cuando el formulario se carga por primera vez.
        /// </summary>
        private void Proyecto_Load(object sender, EventArgs e)
        {
            // Configura la apariencia inicial del DataGridView
            ConfigurarDataGridView();
            // Carga los datos iniciales de la base de datos en el Grid
            ActualizarVista();
        }

        // --- Manejadores de Eventos (Botones CRUD) ---

        /// <summary>
        /// Manejador del clic en el botón 'Registrar'.
        /// Inserta un nuevo Pokémon en la base de datos.
        /// </summary>
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            int id;
            double altura, peso;

            // Validación de entrada: asegura que los campos numéricos sean válidos y los de texto no estén vacíos.
            if (!int.TryParse(txtid.Text, out id) || string.IsNullOrWhiteSpace(txtnombre.Text) ||
                !double.TryParse(txtaltura.Text, out altura) || !double.TryParse(txtpeso.Text, out peso))
            {
                MessageBox.Show("Por favor, asegúrate de llenar todos los campos y que el ID, la Altura y el Peso sean números válidos.", "Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución si la validación falla
            }

            // Consulta SQL parametrizada para INSERTAR un nuevo registro.
            // 'Activo = 1' se usa para el borrado lógico (1 = visible, 0 = borrado).
            string query = "INSERT INTO pokemones (Id, Nombre, Tipo, Altura, Peso, Habilidad, Activo) " +
                           "VALUES (@Id, @Nombre, @Tipo, @Altura, @Peso, @Habilidad, 1)";

            try
            {
                // 'using' asegura que la conexión se cierre automáticamente, incluso si hay un error.
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Añadir parámetros previene la inyección SQL.
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                        cmd.Parameters.AddWithValue("@Tipo", txttipo.Text);
                        cmd.Parameters.AddWithValue("@Altura", altura);
                        cmd.Parameters.AddWithValue("@Peso", peso);
                        cmd.Parameters.AddWithValue("@Habilidad", txthabilidad.Text);

                        // Ejecuta la consulta (no devuelve datos, solo inserta).
                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"¡{txtnombre.Text} ha sido registrado con éxito!", "Registro Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            // Captura específica para error de "ID duplicado" (Primary Key violation).
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show($"Error: El ID {id} ya existe. No se puede registrar un Pokémon con un ID duplicado.", "ID Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Captura genérica para otros errores de base de datos.
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el Pokémon: {ex.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresca el DataGridView y limpia los campos de texto.
            ActualizarVista();
            LimpiarCampos();
        }

        /// <summary>
        /// Manejador del clic en el botón 'Modificar'.
        /// Actualiza un Pokémon existente en la base de datos.
        /// </summary>
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            // Valida que haya una fila seleccionada en el grid.
            if (dgvpokedex.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un Pokémon de la lista para modificar.", "Ningún Pokémon Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            double altura, peso;

            // Validación de entrada para los campos numéricos.
            // El ID se toma del TextBox, que debería estar bloqueado o llenado por la selección.
            if (!int.TryParse(txtid.Text, out id) || !double.TryParse(txtaltura.Text, out altura) || !double.TryParse(txtpeso.Text, out peso))
            {
                MessageBox.Show("Por favor, asegúrate de que el ID, la Altura y el Peso sean números válidos.", "Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Consulta SQL parametrizada para ACTUALIZAR un registro existente.
            string query = "UPDATE pokemones SET Nombre = @Nombre, Tipo = @Tipo, Altura = @Altura, " +
                           "Peso = @Peso, Habilidad = @Habilidad WHERE Id = @Id";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Añadir parámetros
                        cmd.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                        cmd.Parameters.AddWithValue("@Tipo", txttipo.Text);
                        cmd.Parameters.AddWithValue("@Altura", altura);
                        cmd.Parameters.AddWithValue("@Peso", peso);
                        cmd.Parameters.AddWithValue("@Habilidad", txthabilidad.Text);
                        cmd.Parameters.AddWithValue("@Id", id); // El ID se usa en el WHERE

                        // Ejecuta la consulta y obtiene el número de filas afectadas.
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("¡Datos del Pokémon actualizados!", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún Pokémon con ese ID para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el Pokémon: {ex.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresca el DataGridView para mostrar los cambios.
            ActualizarVista();
        }

        /// <summary>
        /// Manejador del clic en el botón 'Liberar'.
        /// Realiza un borrado lógico (soft delete) del Pokémon.
        /// </summary>
        private void btnliberar_Click(object sender, EventArgs e)
        {
            // Valida que haya una fila seleccionada.
            if (dgvpokedex.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un Pokémon de la lista para liberar.", "Ningún Pokémon Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idParaLiberar;
            // Valida el ID del Pokémon a liberar.
            if (!int.TryParse(txtid.Text, out idParaLiberar))
            {
                MessageBox.Show("El ID del Pokémon no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pide confirmación al usuario antes de borrar.
            var confirmacion = MessageBox.Show($"¿Estás seguro de que quieres liberar a {txtnombre.Text}?", "Confirmar Liberación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                // Consulta SQL para borrado lógico: pone 'Activo = 0' en lugar de 'DELETE'.
                string query = "UPDATE pokemones SET Activo = 0 WHERE Id = @Id";

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", idParaLiberar);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show($"{txtnombre.Text} ha sido liberado.", "Liberación Exitosa");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al liberar el Pokémon: {ex.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Refresca la vista (el Pokémon desaparecerá) y limpia los campos.
                ActualizarVista();
                LimpiarCampos();
            }
        }

        // --- Manejadores de Eventos (UI y Búsqueda) ---

        /// <summary>
        /// Manejador del clic en el botón 'Limpiar'.
        /// Limpia todos los campos de texto del formulario.
        /// </summary>
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        /// <summary>
        /// Manejador del clic en el botón 'Buscar'.
        /// Busca Pokémon por ID o Nombre y filtra el DataGridView.
        /// </summary>
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtbuscar.Text.ToLower();

            // Si la búsqueda está vacía, simplemente recarga la vista completa.
            if (string.IsNullOrWhiteSpace(busqueda))
            {
                ActualizarVista();
                LimpiarCampos();
                return;
            }

            List<Pokemon> resultados = new List<Pokemon>();

            // Consulta SQL que busca Pokémon activos por Nombre (LIKE) o ID (LIKE).
            // Usar LIKE en ID funciona en MySQL por conversión implícita.
            string query = "SELECT Id, Nombre, Tipo, Altura, Peso, Habilidad FROM pokemones " +
                           "WHERE Activo = 1 AND (LOWER(Nombre) LIKE @busqueda OR Id LIKE @busqueda)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Se añaden '%' para que LIKE busque coincidencias parciales.
                        cmd.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Pokemon p = new Pokemon
                                {
                                    Id = reader.GetInt32("Id"),
                                    Nombre = reader.GetString("Nombre"),
                                    // Comprueba si los valores de la BD son NULL antes de leerlos.
                                    Tipo = reader.IsDBNull(reader.GetOrdinal("Tipo")) ? "" : reader.GetString("Tipo"),
                                    Altura = reader.IsDBNull(reader.GetOrdinal("Altura")) ? 0 : reader.GetDouble("Altura"),
                                    Peso = reader.IsDBNull(reader.GetOrdinal("Peso")) ? 0 : reader.GetDouble("Peso"),
                                    Habilidad = reader.IsDBNull(reader.GetOrdinal("Habilidad")) ? "" : reader.GetString("Habilidad"),
                                    Activo = true
                                };
                                resultados.Add(p);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Actualiza el DataGridView con la lista de resultados de la búsqueda.
            dgvpokedex.DataSource = null;
            dgvpokedex.DataSource = resultados;

            // Si solo se encontró 1 resultado, carga sus datos en el formulario.
            if (resultados.Count == 1)
            {
                CargarDatosEnFormulario(resultados[0]);
            }
            else
            {
                // Si hay 0 o más de 1 resultado, limpia los campos.
                LimpiarCampos();
            }
        }

        // --- Manejadores de Eventos (DataGridView) ---

        /// <summary>
        /// Se ejecuta cuando el usuario cambia la selección de fila en el DataGridView.
        /// </summary>
        private void dgvpokedex_SelectionChanged(object sender, EventArgs e)
        {
            // Valida que la fila seleccionada no sea nula y contenga datos.
            if (dgvpokedex.CurrentRow != null && dgvpokedex.CurrentRow.DataBoundItem != null)
            {
                // Convierte el objeto de datos (DataBoundItem) de nuevo a un objeto Pokemon.
                Pokemon pokemonSeleccionado = (Pokemon)dgvpokedex.CurrentRow.DataBoundItem;

                // Carga los datos de ese Pokémon en los campos de texto.
                CargarDatosEnFormulario(pokemonSeleccionado);
            }
        }

        // --- Métodos de Ayuda (Lógica y Base de Datos) ---

        /// <summary>
        /// Carga todos los Pokémon 'Activos' (Activo = 1) de la base de datos
        /// y refresca el DataGridView.
        /// </summary>
        private void ActualizarVista()
        {
            List<Pokemon> pokemonesActivos = new List<Pokemon>();
            // Consulta SQL para obtener solo los Pokémon visibles.
            string query = "SELECT Id, Nombre, Tipo, Altura, Peso, Habilidad FROM pokemones WHERE Activo = 1";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Itera sobre cada fila devuelta por la consulta.
                        while (reader.Read())
                        {
                            // Crea un objeto Pokemon por cada registro.
                            Pokemon p = new Pokemon
                            {
                                Id = reader.GetInt32("Id"),
                                Nombre = reader.GetString("Nombre"),
                                Tipo = reader.IsDBNull(reader.GetOrdinal("Tipo")) ? "" : reader.GetString("Tipo"),
                                Altura = reader.IsDBNull(reader.GetOrdinal("Altura")) ? 0 : reader.GetDouble("Altura"),
                                Peso = reader.IsDBNull(reader.GetOrdinal("Peso")) ? 0 : reader.GetDouble("Peso"),
                                Habilidad = reader.IsDBNull(reader.GetOrdinal("Habilidad")) ? "" : reader.GetString("Habilidad"),
                                Activo = true
                            };
                            // Añade el Pokémon a la lista.
                            pokemonesActivos.Add(p);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los Pokémon: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Asigna la lista de Pokémon como la fuente de datos del DataGridView.
            // Ponerlo a null primero es una buena práctica para forzar el refresco completo.
            dgvpokedex.DataSource = null;
            dgvpokedex.DataSource = pokemonesActivos;
        }

        // --- Métodos de Ayuda (UI) ---

        /// <summary>
        /// Rellena los campos de texto (TextBox) del formulario
        /// con los datos de un objeto Pokemon.
        /// </summary>
        /// <param name="pokemon">El objeto Pokémon cuyos datos se mostrarán.</param>
        private void CargarDatosEnFormulario(Pokemon pokemon)
        {
            txtid.Text = pokemon.Id.ToString();
            txtnombre.Text = pokemon.Nombre;
            txttipo.Text = pokemon.Tipo;
            txtaltura.Text = pokemon.Altura.ToString();
            txtpeso.Text = pokemon.Peso.ToString();
            txthabilidad.Text = pokemon.Habilidad;
        }

        /// <summary>
        /// Limpia el contenido de todos los campos de texto (TextBox)
        /// y quita la selección del DataGridView.
        /// </summary>
        private void LimpiarCampos()
        {
            txtid.Clear();
            txtnombre.Clear();
            txttipo.Clear();
            txtaltura.Clear();
            txtpeso.Clear();
            txthabilidad.Clear();
            dgvpokedex.ClearSelection();
        }

        /// <summary>
        /// Configura las columnas del DataGridView manualmente.
        /// Esto da más control que dejar que se generen automáticamente.
        /// </summary>
        private void ConfigurarDataGridView()
        {
            // Desactiva la generación automática de columnas.
            dgvpokedex.AutoGenerateColumns = false;
            dgvpokedex.Columns.Clear();

            // Añade manualmente las columnas que quieres mostrar.
            // 'DataPropertyName' debe coincidir EXACTAMENTE con el nombre de la propiedad en la struct 'Pokemon'.
            dgvpokedex.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID" });
            dgvpokedex.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nombre", HeaderText = "NOMBRE" });
            dgvpokedex.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Tipo", HeaderText = "TIPO" });

            // Hace que la columna "Nombre" ocupe el espacio restante.
            dgvpokedex.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // Este evento estaba en tu código original, pero vacío. Lo dejo por si lo necesitas.
        private void gbxDatosPokemon_Enter(object sender, EventArgs e)
        {
            // Evento vacío
        }
    }
}