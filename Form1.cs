namespace ListaDeTarefas
{
    public partial class Form1 : Form
    {
        public class Tarefa
        {
            public CheckBox checkTarefa;

            public Panel container;

            public Tarefa()
            {
                checkTarefa = new CheckBox();
                container = new Panel();

                checkTarefa.AutoSize = true;
                checkTarefa.Location = new Point(0, 5);
                checkTarefa.Font = new Font("Arial", 10);

                container.Size = new Size(300, 30);
                container.Controls.Add(checkTarefa);
            }

            public void SetText(string text)
            {
                checkTarefa.Text = text;
            }

            public void ConnectEvent(EventHandler evento)
            {
                checkTarefa.CheckedChanged += evento;
            }
        }

        public List<Tarefa> tarefas = new List<Tarefa>();
        int spaceY = 10;

        public void AdicionarTarefa(Tarefa tarefa)
        {
            tarefa.container.Location = new Point(10, spaceY);
            panelTarefas.Controls.Add(tarefa.container);
            spaceY += tarefa.container.Height + 5;

            tarefas.Add(tarefa);
            tarefasInput.Items.Add(tarefa.checkTarefa.Text);
        }

        public void RemoverTarefa(string nomeTarefa)
        {
            Tarefa tarefa = tarefas.Find(t => t.checkTarefa.Text.Equals(nomeTarefa, StringComparison.OrdinalIgnoreCase));

            if (tarefa != null)
            {
                panelTarefas.Controls.Remove(tarefa.container);
                tarefas.Remove(tarefa);
                tarefasInput.Items.Remove(tarefa.checkTarefa.Text);

                ReogarnizarTarefas();

                MessageBox.Show("Tarefa removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tarefa não foi achada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReogarnizarTarefas()
        {
            int y = 10;

            foreach (var tarefa in tarefas)
            {
                tarefa.container.Location = new Point(10, y);
                y += tarefa.container.Height + 5;
            }

            spaceY = y;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string nome = tarefasInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome))
            {
                return;
            }

            bool tarefa_existe = tarefas.Any(t => t.checkTarefa.Text.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (tarefa_existe)
            {
                MessageBox.Show("Já existe uma tarefa com esse nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Tarefa nova_tarefa = new Tarefa();
            nova_tarefa.SetText(tarefasInput.Text);

            nova_tarefa.ConnectEvent((s, ev) =>
            {
                if (nova_tarefa.checkTarefa.Checked)
                {
                    nova_tarefa.checkTarefa.Font = new Font(nova_tarefa.checkTarefa.Font, FontStyle.Strikeout);
                }
                else
                {
                    nova_tarefa.checkTarefa.Font = new Font(nova_tarefa.checkTarefa.Font, FontStyle.Regular);
                }

            });

            AdicionarTarefa(nova_tarefa);
            tarefasInput.Text = "";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tarefasInput.Text))
            {
                return;
            }

            RemoverTarefa(tarefasInput.Text.Trim());
            tarefasInput.Text = "";
        }
    }
}