namespace ListaDeTarefas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            addButton = new Button();
            tarefasGroup = new GroupBox();
            panelTarefas = new FlowLayoutPanel();
            removeButton = new Button();
            tarefasInput = new ComboBox();
            tarefasGroup.SuspendLayout();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(398, 415);
            addButton.Name = "addButton";
            addButton.Size = new Size(32, 23);
            addButton.TabIndex = 1;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // tarefasGroup
            // 
            tarefasGroup.Controls.Add(panelTarefas);
            tarefasGroup.Location = new Point(12, 12);
            tarefasGroup.Name = "tarefasGroup";
            tarefasGroup.Size = new Size(418, 397);
            tarefasGroup.TabIndex = 2;
            tarefasGroup.TabStop = false;
            tarefasGroup.Text = "Tarefas";
            // 
            // panelTarefas
            // 
            panelTarefas.AutoScroll = true;
            panelTarefas.Location = new Point(6, 22);
            panelTarefas.Name = "panelTarefas";
            panelTarefas.Size = new Size(406, 369);
            panelTarefas.TabIndex = 0;
            // 
            // removeButton
            // 
            removeButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            removeButton.Location = new Point(360, 415);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(32, 23);
            removeButton.TabIndex = 3;
            removeButton.Text = "-";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // tarefasInput
            // 
            tarefasInput.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tarefasInput.FormattingEnabled = true;
            tarefasInput.Location = new Point(12, 415);
            tarefasInput.Name = "tarefasInput";
            tarefasInput.Size = new Size(342, 24);
            tarefasInput.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 450);
            Controls.Add(tarefasInput);
            Controls.Add(removeButton);
            Controls.Add(tarefasGroup);
            Controls.Add(addButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Lista de Tarefas";
            tarefasGroup.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private GroupBox tarefasGroup;
        private Button removeButton;
        private FlowLayoutPanel panelTarefas;
        private ComboBox tarefasInput;
    }
}