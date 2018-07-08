namespace ProtoTrial.Test
{
    partial class Form1
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
            this.btnRocket = new System.Windows.Forms.Button();
            this.btnASMXTest = new System.Windows.Forms.Button();
            this.btnSatellite = new System.Windows.Forms.Button();
            this.chkDumpBase64 = new System.Windows.Forms.CheckBox();
            this.txtBase64 = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoJson = new System.Windows.Forms.RadioButton();
            this.rdoProtobufBase64 = new System.Windows.Forms.RadioButton();
            this.rdoProtobuf = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResponseStatus = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRocket
            // 
            this.btnRocket.Location = new System.Drawing.Point(200, 158);
            this.btnRocket.Name = "btnRocket";
            this.btnRocket.Size = new System.Drawing.Size(75, 23);
            this.btnRocket.TabIndex = 2;
            this.btnRocket.Text = "Rocket";
            this.btnRocket.UseVisualStyleBackColor = true;
            this.btnRocket.Click += new System.EventHandler(this.btnRocket_Click);
            // 
            // btnASMXTest
            // 
            this.btnASMXTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnASMXTest.Location = new System.Drawing.Point(38, 306);
            this.btnASMXTest.Name = "btnASMXTest";
            this.btnASMXTest.Size = new System.Drawing.Size(75, 23);
            this.btnASMXTest.TabIndex = 6;
            this.btnASMXTest.Text = "ASMX Test";
            this.btnASMXTest.UseVisualStyleBackColor = true;
            this.btnASMXTest.Click += new System.EventHandler(this.btnASMXTest_Click);
            // 
            // btnSatellite
            // 
            this.btnSatellite.Location = new System.Drawing.Point(281, 158);
            this.btnSatellite.Name = "btnSatellite";
            this.btnSatellite.Size = new System.Drawing.Size(75, 23);
            this.btnSatellite.TabIndex = 3;
            this.btnSatellite.Text = "Satellite";
            this.btnSatellite.UseVisualStyleBackColor = true;
            this.btnSatellite.Click += new System.EventHandler(this.btnSatellite_Click);
            // 
            // chkDumpBase64
            // 
            this.chkDumpBase64.AutoSize = true;
            this.chkDumpBase64.Location = new System.Drawing.Point(362, 162);
            this.chkDumpBase64.Name = "chkDumpBase64";
            this.chkDumpBase64.Size = new System.Drawing.Size(93, 17);
            this.chkDumpBase64.TabIndex = 4;
            this.chkDumpBase64.Text = "Dump Base64";
            this.chkDumpBase64.UseVisualStyleBackColor = true;
            // 
            // txtBase64
            // 
            this.txtBase64.Location = new System.Drawing.Point(200, 12);
            this.txtBase64.Multiline = true;
            this.txtBase64.Name = "txtBase64";
            this.txtBase64.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBase64.Size = new System.Drawing.Size(588, 140);
            this.txtBase64.TabIndex = 1;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(200, 189);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(588, 140);
            this.txtResponse.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoProtobuf);
            this.groupBox1.Controls.Add(this.rdoProtobufBase64);
            this.groupBox1.Controls.Add(this.rdoJson);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return Format";
            // 
            // rdoJson
            // 
            this.rdoJson.AutoSize = true;
            this.rdoJson.Checked = true;
            this.rdoJson.Location = new System.Drawing.Point(6, 16);
            this.rdoJson.Name = "rdoJson";
            this.rdoJson.Size = new System.Drawing.Size(53, 17);
            this.rdoJson.TabIndex = 0;
            this.rdoJson.TabStop = true;
            this.rdoJson.Text = "JSON";
            this.rdoJson.UseVisualStyleBackColor = true;
            // 
            // rdoProtobufBase64
            // 
            this.rdoProtobufBase64.AutoSize = true;
            this.rdoProtobufBase64.Location = new System.Drawing.Point(6, 39);
            this.rdoProtobufBase64.Name = "rdoProtobufBase64";
            this.rdoProtobufBase64.Size = new System.Drawing.Size(109, 17);
            this.rdoProtobufBase64.TabIndex = 1;
            this.rdoProtobufBase64.Text = "Protobuf (base64)";
            this.rdoProtobufBase64.UseVisualStyleBackColor = true;
            // 
            // rdoProtobuf
            // 
            this.rdoProtobuf.AutoSize = true;
            this.rdoProtobuf.Location = new System.Drawing.Point(6, 62);
            this.rdoProtobuf.Name = "rdoProtobuf";
            this.rdoProtobuf.Size = new System.Drawing.Size(65, 17);
            this.rdoProtobuf.TabIndex = 2;
            this.rdoProtobuf.Text = "Protobuf";
            this.rdoProtobuf.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Response";
            // 
            // txtResponseStatus
            // 
            this.txtResponseStatus.Location = new System.Drawing.Point(522, 160);
            this.txtResponseStatus.Name = "txtResponseStatus";
            this.txtResponseStatus.Size = new System.Drawing.Size(266, 20);
            this.txtResponseStatus.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.txtResponseStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtBase64);
            this.Controls.Add(this.chkDumpBase64);
            this.Controls.Add(this.btnSatellite);
            this.Controls.Add(this.btnASMXTest);
            this.Controls.Add(this.btnRocket);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRocket;
        private System.Windows.Forms.Button btnASMXTest;
        private System.Windows.Forms.Button btnSatellite;
        private System.Windows.Forms.CheckBox chkDumpBase64;
        private System.Windows.Forms.TextBox txtBase64;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoProtobuf;
        private System.Windows.Forms.RadioButton rdoProtobufBase64;
        private System.Windows.Forms.RadioButton rdoJson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResponseStatus;
    }
}

