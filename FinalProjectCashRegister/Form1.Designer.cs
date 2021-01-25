
namespace FinalProjectCashRegister
{
    partial class donscashRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(donscashRegister));
            this.receiptLabel = new System.Windows.Forms.Label();
            this.voidButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.tenderedTextbox = new System.Windows.Forms.TextBox();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.mdrinkButton = new System.Windows.Forms.Button();
            this.ldrinkButton = new System.Windows.Forms.Button();
            this.sdrinkButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.noNumbersLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.scoffeeLabel = new System.Windows.Forms.Button();
            this.mcoffeeLabel = new System.Windows.Forms.Button();
            this.mshakeButton = new System.Windows.Forms.Button();
            this.lcoffeeLabel = new System.Windows.Forms.Button();
            this.sfriesButton = new System.Windows.Forms.Button();
            this.lshakeButton = new System.Windows.Forms.Button();
            this.sshakeButton = new System.Windows.Forms.Button();
            this.lfriesButton = new System.Windows.Forms.Button();
            this.mfriesButton = new System.Windows.Forms.Button();
            this.bigmacButton = new System.Windows.Forms.Button();
            this.quartcheeseButton = new System.Windows.Forms.Button();
            this.quartbltButton = new System.Windows.Forms.Button();
            this.doubbigmacButton = new System.Windows.Forms.Button();
            this.doubquartcheeseButton = new System.Windows.Forms.Button();
            this.doubquartbltButton = new System.Windows.Forms.Button();
            this.filetButton = new System.Windows.Forms.Button();
            this.jrchickButton = new System.Windows.Forms.Button();
            this.dailytotalButton = new System.Windows.Forms.Button();
            this.mcchickButton = new System.Windows.Forms.Button();
            this.sixpcButton = new System.Windows.Forms.Button();
            this.tenpcButton = new System.Windows.Forms.Button();
            this.twentypcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.White;
            this.receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.receiptLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptLabel.Font = new System.Drawing.Font("Consolas", 7F);
            this.receiptLabel.ForeColor = System.Drawing.Color.Black;
            this.receiptLabel.Location = new System.Drawing.Point(668, 19);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(471, 676);
            this.receiptLabel.TabIndex = 0;
            this.receiptLabel.Text = "New Order";
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // voidButton
            // 
            this.voidButton.BackColor = System.Drawing.Color.Gray;
            this.voidButton.FlatAppearance.BorderSize = 5;
            this.voidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voidButton.Location = new System.Drawing.Point(439, 19);
            this.voidButton.Name = "voidButton";
            this.voidButton.Size = new System.Drawing.Size(218, 48);
            this.voidButton.TabIndex = 1;
            this.voidButton.Tag = "";
            this.voidButton.Text = "Void";
            this.voidButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.voidButton.UseVisualStyleBackColor = false;
            this.voidButton.Click += new System.EventHandler(this.voidButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Consolas", 8F);
            this.totalLabel.Location = new System.Drawing.Point(434, 221);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(228, 23);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total:    $0.00";
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Consolas", 8F);
            this.taxLabel.Location = new System.Drawing.Point(434, 182);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(223, 23);
            this.taxLabel.TabIndex = 3;
            this.taxLabel.Text = "Tax:      $0.00";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Font = new System.Drawing.Font("Consolas", 8F);
            this.subtotalLabel.Location = new System.Drawing.Point(434, 144);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(223, 23);
            this.subtotalLabel.TabIndex = 4;
            this.subtotalLabel.Text = "Subtotal: $0.00";
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.Gray;
            this.totalButton.FlatAppearance.BorderSize = 5;
            this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalButton.Location = new System.Drawing.Point(439, 88);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(213, 39);
            this.totalButton.TabIndex = 5;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // tenderedTextbox
            // 
            this.tenderedTextbox.Location = new System.Drawing.Point(444, 334);
            this.tenderedTextbox.Name = "tenderedTextbox";
            this.tenderedTextbox.Size = new System.Drawing.Size(213, 31);
            this.tenderedTextbox.TabIndex = 6;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Location = new System.Drawing.Point(444, 296);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(213, 23);
            this.tenderedLabel.TabIndex = 7;
            this.tenderedLabel.Text = "Tendered";
            this.tenderedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Consolas", 8F);
            this.changeLabel.Location = new System.Drawing.Point(444, 481);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(213, 23);
            this.changeLabel.TabIndex = 8;
            this.changeLabel.Text = "Change:    $0.00";
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.Gray;
            this.printButton.Enabled = false;
            this.printButton.FlatAppearance.BorderSize = 5;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Location = new System.Drawing.Point(444, 592);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(213, 44);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // mdrinkButton
            // 
            this.mdrinkButton.BackColor = System.Drawing.Color.Red;
            this.mdrinkButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mdrinkButton.FlatAppearance.BorderSize = 2;
            this.mdrinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdrinkButton.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdrinkButton.ForeColor = System.Drawing.Color.Black;
            this.mdrinkButton.Location = new System.Drawing.Point(328, 125);
            this.mdrinkButton.Name = "mdrinkButton";
            this.mdrinkButton.Size = new System.Drawing.Size(100, 100);
            this.mdrinkButton.TabIndex = 10;
            this.mdrinkButton.Text = "Medium Drink";
            this.mdrinkButton.UseVisualStyleBackColor = false;
            this.mdrinkButton.Click += new System.EventHandler(this.mdrinkButton_Click);
            // 
            // ldrinkButton
            // 
            this.ldrinkButton.BackColor = System.Drawing.Color.Red;
            this.ldrinkButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ldrinkButton.FlatAppearance.BorderSize = 2;
            this.ldrinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ldrinkButton.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldrinkButton.ForeColor = System.Drawing.Color.Black;
            this.ldrinkButton.Location = new System.Drawing.Point(328, 231);
            this.ldrinkButton.Name = "ldrinkButton";
            this.ldrinkButton.Size = new System.Drawing.Size(100, 100);
            this.ldrinkButton.TabIndex = 11;
            this.ldrinkButton.Text = "Large Drink";
            this.ldrinkButton.UseVisualStyleBackColor = false;
            this.ldrinkButton.Click += new System.EventHandler(this.ldrinkButton_Click);
            // 
            // sdrinkButton
            // 
            this.sdrinkButton.BackColor = System.Drawing.Color.Red;
            this.sdrinkButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sdrinkButton.FlatAppearance.BorderSize = 2;
            this.sdrinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdrinkButton.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdrinkButton.ForeColor = System.Drawing.Color.Black;
            this.sdrinkButton.Location = new System.Drawing.Point(328, 19);
            this.sdrinkButton.Name = "sdrinkButton";
            this.sdrinkButton.Size = new System.Drawing.Size(100, 100);
            this.sdrinkButton.TabIndex = 12;
            this.sdrinkButton.Text = "Small Drink";
            this.sdrinkButton.UseVisualStyleBackColor = false;
            this.sdrinkButton.Click += new System.EventHandler(this.sdrinkButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Gray;
            this.changeButton.FlatAppearance.BorderSize = 5;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Location = new System.Drawing.Point(444, 528);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(213, 43);
            this.changeButton.TabIndex = 13;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // noNumbersLabel
            // 
            this.noNumbersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noNumbersLabel.Location = new System.Drawing.Point(444, 380);
            this.noNumbersLabel.Name = "noNumbersLabel";
            this.noNumbersLabel.Size = new System.Drawing.Size(213, 77);
            this.noNumbersLabel.TabIndex = 14;
            this.noNumbersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.Gray;
            this.newOrderButton.FlatAppearance.BorderSize = 5;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Location = new System.Drawing.Point(444, 653);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(213, 42);
            this.newOrderButton.TabIndex = 15;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // scoffeeLabel
            // 
            this.scoffeeLabel.BackColor = System.Drawing.Color.Red;
            this.scoffeeLabel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.scoffeeLabel.FlatAppearance.BorderSize = 2;
            this.scoffeeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoffeeLabel.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoffeeLabel.ForeColor = System.Drawing.Color.Black;
            this.scoffeeLabel.Location = new System.Drawing.Point(328, 337);
            this.scoffeeLabel.Name = "scoffeeLabel";
            this.scoffeeLabel.Size = new System.Drawing.Size(100, 100);
            this.scoffeeLabel.TabIndex = 16;
            this.scoffeeLabel.Text = "Small Coffee";
            this.scoffeeLabel.UseVisualStyleBackColor = false;
            this.scoffeeLabel.Click += new System.EventHandler(this.scoffeeLabel_Click);
            // 
            // mcoffeeLabel
            // 
            this.mcoffeeLabel.BackColor = System.Drawing.Color.Red;
            this.mcoffeeLabel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mcoffeeLabel.FlatAppearance.BorderSize = 2;
            this.mcoffeeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mcoffeeLabel.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcoffeeLabel.ForeColor = System.Drawing.Color.Black;
            this.mcoffeeLabel.Location = new System.Drawing.Point(328, 443);
            this.mcoffeeLabel.Name = "mcoffeeLabel";
            this.mcoffeeLabel.Size = new System.Drawing.Size(100, 100);
            this.mcoffeeLabel.TabIndex = 17;
            this.mcoffeeLabel.Text = "Medium Coffee";
            this.mcoffeeLabel.UseVisualStyleBackColor = false;
            this.mcoffeeLabel.Click += new System.EventHandler(this.mcoffeeLabel_Click);
            // 
            // mshakeButton
            // 
            this.mshakeButton.BackColor = System.Drawing.Color.Red;
            this.mshakeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mshakeButton.FlatAppearance.BorderSize = 2;
            this.mshakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mshakeButton.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mshakeButton.ForeColor = System.Drawing.Color.Black;
            this.mshakeButton.Location = new System.Drawing.Point(222, 125);
            this.mshakeButton.Name = "mshakeButton";
            this.mshakeButton.Size = new System.Drawing.Size(100, 100);
            this.mshakeButton.TabIndex = 18;
            this.mshakeButton.Text = "Medium Shake";
            this.mshakeButton.UseVisualStyleBackColor = false;
            this.mshakeButton.Click += new System.EventHandler(this.mshakeButton_Click);
            // 
            // lcoffeeLabel
            // 
            this.lcoffeeLabel.BackColor = System.Drawing.Color.Red;
            this.lcoffeeLabel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.lcoffeeLabel.FlatAppearance.BorderSize = 2;
            this.lcoffeeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lcoffeeLabel.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcoffeeLabel.ForeColor = System.Drawing.Color.Black;
            this.lcoffeeLabel.Location = new System.Drawing.Point(328, 549);
            this.lcoffeeLabel.Name = "lcoffeeLabel";
            this.lcoffeeLabel.Size = new System.Drawing.Size(100, 100);
            this.lcoffeeLabel.TabIndex = 19;
            this.lcoffeeLabel.Text = "Large Coffee";
            this.lcoffeeLabel.UseVisualStyleBackColor = false;
            this.lcoffeeLabel.Click += new System.EventHandler(this.lcoffeeLabel_Click);
            // 
            // sfriesButton
            // 
            this.sfriesButton.BackColor = System.Drawing.Color.Red;
            this.sfriesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sfriesButton.FlatAppearance.BorderSize = 2;
            this.sfriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfriesButton.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfriesButton.ForeColor = System.Drawing.Color.Black;
            this.sfriesButton.Location = new System.Drawing.Point(222, 337);
            this.sfriesButton.Name = "sfriesButton";
            this.sfriesButton.Size = new System.Drawing.Size(100, 100);
            this.sfriesButton.TabIndex = 20;
            this.sfriesButton.Text = "Small Fries";
            this.sfriesButton.UseVisualStyleBackColor = false;
            this.sfriesButton.Click += new System.EventHandler(this.sfriesButton_Click);
            // 
            // lshakeButton
            // 
            this.lshakeButton.BackColor = System.Drawing.Color.Red;
            this.lshakeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.lshakeButton.FlatAppearance.BorderSize = 2;
            this.lshakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lshakeButton.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lshakeButton.ForeColor = System.Drawing.Color.Black;
            this.lshakeButton.Location = new System.Drawing.Point(222, 231);
            this.lshakeButton.Name = "lshakeButton";
            this.lshakeButton.Size = new System.Drawing.Size(100, 100);
            this.lshakeButton.TabIndex = 21;
            this.lshakeButton.Text = "Large Shake";
            this.lshakeButton.UseVisualStyleBackColor = false;
            this.lshakeButton.Click += new System.EventHandler(this.lshakeButton_Click);
            // 
            // sshakeButton
            // 
            this.sshakeButton.BackColor = System.Drawing.Color.Red;
            this.sshakeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sshakeButton.FlatAppearance.BorderSize = 2;
            this.sshakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sshakeButton.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sshakeButton.ForeColor = System.Drawing.Color.Black;
            this.sshakeButton.Location = new System.Drawing.Point(222, 19);
            this.sshakeButton.Name = "sshakeButton";
            this.sshakeButton.Size = new System.Drawing.Size(100, 100);
            this.sshakeButton.TabIndex = 22;
            this.sshakeButton.Text = "Small Shake";
            this.sshakeButton.UseVisualStyleBackColor = false;
            this.sshakeButton.Click += new System.EventHandler(this.sshakeButton_Click);
            // 
            // lfriesButton
            // 
            this.lfriesButton.BackColor = System.Drawing.Color.Red;
            this.lfriesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.lfriesButton.FlatAppearance.BorderSize = 2;
            this.lfriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lfriesButton.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfriesButton.ForeColor = System.Drawing.Color.Black;
            this.lfriesButton.Location = new System.Drawing.Point(222, 549);
            this.lfriesButton.Name = "lfriesButton";
            this.lfriesButton.Size = new System.Drawing.Size(100, 100);
            this.lfriesButton.TabIndex = 23;
            this.lfriesButton.Text = "Large Fries";
            this.lfriesButton.UseVisualStyleBackColor = false;
            this.lfriesButton.Click += new System.EventHandler(this.lfriesButton_Click);
            // 
            // mfriesButton
            // 
            this.mfriesButton.BackColor = System.Drawing.Color.Red;
            this.mfriesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mfriesButton.FlatAppearance.BorderSize = 2;
            this.mfriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mfriesButton.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfriesButton.ForeColor = System.Drawing.Color.Black;
            this.mfriesButton.Location = new System.Drawing.Point(222, 443);
            this.mfriesButton.Name = "mfriesButton";
            this.mfriesButton.Size = new System.Drawing.Size(100, 100);
            this.mfriesButton.TabIndex = 24;
            this.mfriesButton.Text = "Medium Fries";
            this.mfriesButton.UseVisualStyleBackColor = false;
            this.mfriesButton.Click += new System.EventHandler(this.mfriesButton_Click);
            // 
            // bigmacButton
            // 
            this.bigmacButton.BackColor = System.Drawing.Color.Red;
            this.bigmacButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bigmacButton.FlatAppearance.BorderSize = 2;
            this.bigmacButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bigmacButton.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigmacButton.ForeColor = System.Drawing.Color.Black;
            this.bigmacButton.Location = new System.Drawing.Point(116, 19);
            this.bigmacButton.Name = "bigmacButton";
            this.bigmacButton.Size = new System.Drawing.Size(100, 100);
            this.bigmacButton.TabIndex = 25;
            this.bigmacButton.Text = "Big Mac";
            this.bigmacButton.UseVisualStyleBackColor = false;
            this.bigmacButton.Click += new System.EventHandler(this.bigmacButton_Click);
            // 
            // quartcheeseButton
            // 
            this.quartcheeseButton.BackColor = System.Drawing.Color.Red;
            this.quartcheeseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.quartcheeseButton.FlatAppearance.BorderSize = 2;
            this.quartcheeseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quartcheeseButton.Font = new System.Drawing.Font("Corbel Light", 6.7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quartcheeseButton.ForeColor = System.Drawing.Color.Black;
            this.quartcheeseButton.Location = new System.Drawing.Point(116, 231);
            this.quartcheeseButton.Name = "quartcheeseButton";
            this.quartcheeseButton.Size = new System.Drawing.Size(100, 100);
            this.quartcheeseButton.TabIndex = 26;
            this.quartcheeseButton.Text = "Quarter Pounder With Cheese";
            this.quartcheeseButton.UseVisualStyleBackColor = false;
            this.quartcheeseButton.Click += new System.EventHandler(this.quartcheeseButton_Click);
            // 
            // quartbltButton
            // 
            this.quartbltButton.BackColor = System.Drawing.Color.Red;
            this.quartbltButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.quartbltButton.FlatAppearance.BorderSize = 2;
            this.quartbltButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quartbltButton.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quartbltButton.ForeColor = System.Drawing.Color.Black;
            this.quartbltButton.Location = new System.Drawing.Point(116, 443);
            this.quartbltButton.Name = "quartbltButton";
            this.quartbltButton.Size = new System.Drawing.Size(100, 100);
            this.quartbltButton.TabIndex = 27;
            this.quartbltButton.Text = "Quarter Pounder BLT";
            this.quartbltButton.UseVisualStyleBackColor = false;
            this.quartbltButton.Click += new System.EventHandler(this.quartbltButton_Click);
            // 
            // doubbigmacButton
            // 
            this.doubbigmacButton.BackColor = System.Drawing.Color.Red;
            this.doubbigmacButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.doubbigmacButton.FlatAppearance.BorderSize = 2;
            this.doubbigmacButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doubbigmacButton.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubbigmacButton.ForeColor = System.Drawing.Color.Black;
            this.doubbigmacButton.Location = new System.Drawing.Point(116, 125);
            this.doubbigmacButton.Name = "doubbigmacButton";
            this.doubbigmacButton.Size = new System.Drawing.Size(100, 100);
            this.doubbigmacButton.TabIndex = 28;
            this.doubbigmacButton.Text = "Double Big Mac";
            this.doubbigmacButton.UseVisualStyleBackColor = false;
            this.doubbigmacButton.Click += new System.EventHandler(this.doubbigmacButton_Click);
            // 
            // doubquartcheeseButton
            // 
            this.doubquartcheeseButton.BackColor = System.Drawing.Color.Red;
            this.doubquartcheeseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.doubquartcheeseButton.FlatAppearance.BorderSize = 2;
            this.doubquartcheeseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doubquartcheeseButton.Font = new System.Drawing.Font("Corbel Light", 5.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubquartcheeseButton.ForeColor = System.Drawing.Color.Black;
            this.doubquartcheeseButton.Location = new System.Drawing.Point(116, 337);
            this.doubquartcheeseButton.Name = "doubquartcheeseButton";
            this.doubquartcheeseButton.Size = new System.Drawing.Size(100, 100);
            this.doubquartcheeseButton.TabIndex = 29;
            this.doubquartcheeseButton.Text = "Double Quarter Pounder With Cheese";
            this.doubquartcheeseButton.UseVisualStyleBackColor = false;
            this.doubquartcheeseButton.Click += new System.EventHandler(this.doubquartcheeseButton_Click);
            // 
            // doubquartbltButton
            // 
            this.doubquartbltButton.BackColor = System.Drawing.Color.Red;
            this.doubquartbltButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.doubquartbltButton.FlatAppearance.BorderSize = 2;
            this.doubquartbltButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doubquartbltButton.Font = new System.Drawing.Font("Corbel Light", 6.7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubquartbltButton.ForeColor = System.Drawing.Color.Black;
            this.doubquartbltButton.Location = new System.Drawing.Point(116, 549);
            this.doubquartbltButton.Name = "doubquartbltButton";
            this.doubquartbltButton.Size = new System.Drawing.Size(100, 100);
            this.doubquartbltButton.TabIndex = 30;
            this.doubquartbltButton.Text = "Double Quarter Pounder BLT";
            this.doubquartbltButton.UseVisualStyleBackColor = false;
            this.doubquartbltButton.Click += new System.EventHandler(this.doubquartbltButton_Click);
            // 
            // filetButton
            // 
            this.filetButton.BackColor = System.Drawing.Color.Red;
            this.filetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.filetButton.FlatAppearance.BorderSize = 2;
            this.filetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filetButton.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filetButton.ForeColor = System.Drawing.Color.Black;
            this.filetButton.Location = new System.Drawing.Point(10, 19);
            this.filetButton.Name = "filetButton";
            this.filetButton.Size = new System.Drawing.Size(100, 100);
            this.filetButton.TabIndex = 31;
            this.filetButton.Text = "Filet-O-Fish";
            this.filetButton.UseVisualStyleBackColor = false;
            this.filetButton.Click += new System.EventHandler(this.filetButton_Click);
            // 
            // jrchickButton
            // 
            this.jrchickButton.BackColor = System.Drawing.Color.Red;
            this.jrchickButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.jrchickButton.FlatAppearance.BorderSize = 2;
            this.jrchickButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jrchickButton.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jrchickButton.ForeColor = System.Drawing.Color.Black;
            this.jrchickButton.Location = new System.Drawing.Point(10, 125);
            this.jrchickButton.Name = "jrchickButton";
            this.jrchickButton.Size = new System.Drawing.Size(100, 100);
            this.jrchickButton.TabIndex = 32;
            this.jrchickButton.Text = "Jr Chicken";
            this.jrchickButton.UseVisualStyleBackColor = false;
            this.jrchickButton.Click += new System.EventHandler(this.jrchickButton_Click);
            // 
            // dailytotalButton
            // 
            this.dailytotalButton.BackColor = System.Drawing.Color.Gray;
            this.dailytotalButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.dailytotalButton.FlatAppearance.BorderSize = 5;
            this.dailytotalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailytotalButton.Font = new System.Drawing.Font("Corbel Light", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailytotalButton.ForeColor = System.Drawing.Color.Black;
            this.dailytotalButton.Location = new System.Drawing.Point(10, 655);
            this.dailytotalButton.Name = "dailytotalButton";
            this.dailytotalButton.Size = new System.Drawing.Size(418, 42);
            this.dailytotalButton.TabIndex = 33;
            this.dailytotalButton.Text = "Daily Total";
            this.dailytotalButton.UseVisualStyleBackColor = false;
            this.dailytotalButton.Click += new System.EventHandler(this.dailytotalButton_Click);
            // 
            // mcchickButton
            // 
            this.mcchickButton.BackColor = System.Drawing.Color.Red;
            this.mcchickButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mcchickButton.FlatAppearance.BorderSize = 2;
            this.mcchickButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mcchickButton.Font = new System.Drawing.Font("Corbel Light", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcchickButton.ForeColor = System.Drawing.Color.Black;
            this.mcchickButton.Location = new System.Drawing.Point(10, 231);
            this.mcchickButton.Name = "mcchickButton";
            this.mcchickButton.Size = new System.Drawing.Size(100, 100);
            this.mcchickButton.TabIndex = 34;
            this.mcchickButton.Text = "McChicken";
            this.mcchickButton.UseVisualStyleBackColor = false;
            this.mcchickButton.Click += new System.EventHandler(this.mcchickButton_Click);
            // 
            // sixpcButton
            // 
            this.sixpcButton.BackColor = System.Drawing.Color.Red;
            this.sixpcButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sixpcButton.FlatAppearance.BorderSize = 2;
            this.sixpcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixpcButton.Font = new System.Drawing.Font("Corbel Light", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixpcButton.ForeColor = System.Drawing.Color.Black;
            this.sixpcButton.Location = new System.Drawing.Point(10, 338);
            this.sixpcButton.Name = "sixpcButton";
            this.sixpcButton.Size = new System.Drawing.Size(100, 100);
            this.sixpcButton.TabIndex = 35;
            this.sixpcButton.Text = "6 Piece Chicken McNugget";
            this.sixpcButton.UseVisualStyleBackColor = false;
            this.sixpcButton.Click += new System.EventHandler(this.sixpcButton_Click);
            // 
            // tenpcButton
            // 
            this.tenpcButton.BackColor = System.Drawing.Color.Red;
            this.tenpcButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tenpcButton.FlatAppearance.BorderSize = 2;
            this.tenpcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tenpcButton.Font = new System.Drawing.Font("Corbel Light", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenpcButton.ForeColor = System.Drawing.Color.Black;
            this.tenpcButton.Location = new System.Drawing.Point(10, 444);
            this.tenpcButton.Name = "tenpcButton";
            this.tenpcButton.Size = new System.Drawing.Size(100, 100);
            this.tenpcButton.TabIndex = 36;
            this.tenpcButton.Text = "10 Piece Chicken McNugget";
            this.tenpcButton.UseVisualStyleBackColor = false;
            this.tenpcButton.Click += new System.EventHandler(this.tenpcButton_Click);
            // 
            // twentypcButton
            // 
            this.twentypcButton.BackColor = System.Drawing.Color.Red;
            this.twentypcButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.twentypcButton.FlatAppearance.BorderSize = 2;
            this.twentypcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twentypcButton.Font = new System.Drawing.Font("Corbel Light", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twentypcButton.ForeColor = System.Drawing.Color.Black;
            this.twentypcButton.Location = new System.Drawing.Point(10, 549);
            this.twentypcButton.Name = "twentypcButton";
            this.twentypcButton.Size = new System.Drawing.Size(100, 100);
            this.twentypcButton.TabIndex = 37;
            this.twentypcButton.Text = "20 Piece Chicken McNugget";
            this.twentypcButton.UseVisualStyleBackColor = false;
            this.twentypcButton.Click += new System.EventHandler(this.twentypcButton_Click);
            // 
            // donscashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1162, 707);
            this.Controls.Add(this.twentypcButton);
            this.Controls.Add(this.tenpcButton);
            this.Controls.Add(this.sixpcButton);
            this.Controls.Add(this.mcchickButton);
            this.Controls.Add(this.dailytotalButton);
            this.Controls.Add(this.jrchickButton);
            this.Controls.Add(this.filetButton);
            this.Controls.Add(this.doubquartbltButton);
            this.Controls.Add(this.doubquartcheeseButton);
            this.Controls.Add(this.doubbigmacButton);
            this.Controls.Add(this.quartbltButton);
            this.Controls.Add(this.quartcheeseButton);
            this.Controls.Add(this.bigmacButton);
            this.Controls.Add(this.mfriesButton);
            this.Controls.Add(this.lfriesButton);
            this.Controls.Add(this.sshakeButton);
            this.Controls.Add(this.lshakeButton);
            this.Controls.Add(this.sfriesButton);
            this.Controls.Add(this.lcoffeeLabel);
            this.Controls.Add(this.mshakeButton);
            this.Controls.Add(this.mcoffeeLabel);
            this.Controls.Add(this.scoffeeLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.noNumbersLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.sdrinkButton);
            this.Controls.Add(this.ldrinkButton);
            this.Controls.Add(this.mdrinkButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.tenderedTextbox);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.voidButton);
            this.Controls.Add(this.receiptLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "donscashRegister";
            this.Text = "McDonalds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button voidButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.TextBox tenderedTextbox;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button mdrinkButton;
        private System.Windows.Forms.Button ldrinkButton;
        private System.Windows.Forms.Button sdrinkButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label noNumbersLabel;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button scoffeeLabel;
        private System.Windows.Forms.Button mcoffeeLabel;
        private System.Windows.Forms.Button mshakeButton;
        private System.Windows.Forms.Button lcoffeeLabel;
        private System.Windows.Forms.Button sfriesButton;
        private System.Windows.Forms.Button lshakeButton;
        private System.Windows.Forms.Button sshakeButton;
        private System.Windows.Forms.Button lfriesButton;
        private System.Windows.Forms.Button mfriesButton;
        private System.Windows.Forms.Button bigmacButton;
        private System.Windows.Forms.Button quartcheeseButton;
        private System.Windows.Forms.Button quartbltButton;
        private System.Windows.Forms.Button doubbigmacButton;
        private System.Windows.Forms.Button doubquartcheeseButton;
        private System.Windows.Forms.Button doubquartbltButton;
        private System.Windows.Forms.Button filetButton;
        private System.Windows.Forms.Button jrchickButton;
        private System.Windows.Forms.Button dailytotalButton;
        private System.Windows.Forms.Button mcchickButton;
        private System.Windows.Forms.Button sixpcButton;
        private System.Windows.Forms.Button tenpcButton;
        private System.Windows.Forms.Button twentypcButton;
    }
}

