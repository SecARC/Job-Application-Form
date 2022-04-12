
namespace week07_2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkJobTesting = new System.Windows.Forms.CheckBox();
            this.chkJobAnalyst = new System.Windows.Forms.CheckBox();
            this.chkJobMobile = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboBirthPlace = new System.Windows.Forms.ComboBox();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkDrivingLicenseH = new System.Windows.Forms.CheckBox();
            this.chkDrivingLicenseA = new System.Windows.Forms.CheckBox();
            this.chkDrivingLicenseE = new System.Windows.Forms.CheckBox();
            this.chkEngineer = new System.Windows.Forms.CheckBox();
            this.chkDrivingLicenseB = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdCertificationNA = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEducationGPA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEducationGraduateFrom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboEducationLevel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbInterest = new System.Windows.Forms.CheckedListBox();
            this.btnSendForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkJobTesting);
            this.groupBox1.Controls.Add(this.chkJobAnalyst);
            this.groupBox1.Controls.Add(this.chkJobMobile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job Title / İş Seçimi";
            // 
            // chkJobTesting
            // 
            this.chkJobTesting.AutoSize = true;
            this.chkJobTesting.Location = new System.Drawing.Point(10, 85);
            this.chkJobTesting.Name = "chkJobTesting";
            this.chkJobTesting.Size = new System.Drawing.Size(293, 17);
            this.chkJobTesting.TabIndex = 3;
            this.chkJobTesting.Text = "Quality Assurance and Testing / Kalite Güvence ve Test";
            this.chkJobTesting.UseVisualStyleBackColor = true;
            // 
            // chkJobAnalyst
            // 
            this.chkJobAnalyst.AutoSize = true;
            this.chkJobAnalyst.Location = new System.Drawing.Point(10, 61);
            this.chkJobAnalyst.Name = "chkJobAnalyst";
            this.chkJobAnalyst.Size = new System.Drawing.Size(102, 17);
            this.chkJobAnalyst.TabIndex = 2;
            this.chkJobAnalyst.Text = "Analyst / Analist";
            this.chkJobAnalyst.UseVisualStyleBackColor = true;
            // 
            // chkJobMobile
            // 
            this.chkJobMobile.AutoSize = true;
            this.chkJobMobile.Location = new System.Drawing.Point(10, 37);
            this.chkJobMobile.Name = "chkJobMobile";
            this.chkJobMobile.Size = new System.Drawing.Size(297, 17);
            this.chkJobMobile.TabIndex = 1;
            this.chkJobMobile.Text = "Mobile Application Development / Mobil Yazılım Geliştirme";
            this.chkJobMobile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which Job do you apply for? / Hangi İş için başvuruda bulunuyorsunuz?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboBirthPlace);
            this.groupBox2.Controls.Add(this.dtBirthDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFullName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Info / Kişisel Bilgiler";
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(448, 40);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(26, 20);
            this.txtAge.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Your age / Yaşınız";
            // 
            // cboBirthPlace
            // 
            this.cboBirthPlace.FormattingEnabled = true;
            this.cboBirthPlace.Items.AddRange(new object[] {
            "Türkiye",
            "Dünya"});
            this.cboBirthPlace.Location = new System.Drawing.Point(142, 64);
            this.cboBirthPlace.Name = "cboBirthPlace";
            this.cboBirthPlace.Size = new System.Drawing.Size(332, 21);
            this.cboBirthPlace.TabIndex = 5;
            this.cboBirthPlace.Text = "İstanbul";
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Location = new System.Drawing.Point(142, 40);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtBirthDate.TabIndex = 4;
            this.dtBirthDate.ValueChanged += new System.EventHandler(this.dtBirthDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birth Place / Doğum Yeri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birth Date / Doğum Tarihi";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(142, 17);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(332, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fullname / Ad-Soyad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkDrivingLicenseH);
            this.groupBox3.Controls.Add(this.chkDrivingLicenseA);
            this.groupBox3.Controls.Add(this.chkDrivingLicenseE);
            this.groupBox3.Controls.Add(this.chkEngineer);
            this.groupBox3.Controls.Add(this.chkDrivingLicenseB);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.rdCertificationNA);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(499, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Certifications / Sertifikalarınız";
            // 
            // chkDrivingLicenseH
            // 
            this.chkDrivingLicenseH.AutoSize = true;
            this.chkDrivingLicenseH.Location = new System.Drawing.Point(126, 39);
            this.chkDrivingLicenseH.Name = "chkDrivingLicenseH";
            this.chkDrivingLicenseH.Size = new System.Drawing.Size(34, 17);
            this.chkDrivingLicenseH.TabIndex = 5;
            this.chkDrivingLicenseH.Text = "H";
            this.chkDrivingLicenseH.UseVisualStyleBackColor = true;
            this.chkDrivingLicenseH.CheckedChanged += new System.EventHandler(this.chkDrivingLicense_CheckedChanged);
            // 
            // chkDrivingLicenseA
            // 
            this.chkDrivingLicenseA.AutoSize = true;
            this.chkDrivingLicenseA.Location = new System.Drawing.Point(9, 39);
            this.chkDrivingLicenseA.Name = "chkDrivingLicenseA";
            this.chkDrivingLicenseA.Size = new System.Drawing.Size(33, 17);
            this.chkDrivingLicenseA.TabIndex = 8;
            this.chkDrivingLicenseA.Text = "A";
            this.chkDrivingLicenseA.UseVisualStyleBackColor = true;
            this.chkDrivingLicenseA.CheckedChanged += new System.EventHandler(this.chkDrivingLicense_CheckedChanged);
            // 
            // chkDrivingLicenseE
            // 
            this.chkDrivingLicenseE.AutoSize = true;
            this.chkDrivingLicenseE.Location = new System.Drawing.Point(87, 39);
            this.chkDrivingLicenseE.Name = "chkDrivingLicenseE";
            this.chkDrivingLicenseE.Size = new System.Drawing.Size(33, 17);
            this.chkDrivingLicenseE.TabIndex = 4;
            this.chkDrivingLicenseE.Text = "E";
            this.chkDrivingLicenseE.UseVisualStyleBackColor = true;
            this.chkDrivingLicenseE.CheckedChanged += new System.EventHandler(this.chkDrivingLicense_CheckedChanged);
            // 
            // chkEngineer
            // 
            this.chkEngineer.AutoSize = true;
            this.chkEngineer.Location = new System.Drawing.Point(9, 75);
            this.chkEngineer.Name = "chkEngineer";
            this.chkEngineer.Size = new System.Drawing.Size(83, 17);
            this.chkEngineer.TabIndex = 7;
            this.chkEngineer.Text = "I have / Var";
            this.chkEngineer.UseVisualStyleBackColor = true;
            // 
            // chkDrivingLicenseB
            // 
            this.chkDrivingLicenseB.AutoSize = true;
            this.chkDrivingLicenseB.Location = new System.Drawing.Point(48, 39);
            this.chkDrivingLicenseB.Name = "chkDrivingLicenseB";
            this.chkDrivingLicenseB.Size = new System.Drawing.Size(33, 17);
            this.chkDrivingLicenseB.TabIndex = 3;
            this.chkDrivingLicenseB.Text = "B";
            this.chkDrivingLicenseB.UseVisualStyleBackColor = true;
            this.chkDrivingLicenseB.CheckedChanged += new System.EventHandler(this.chkDrivingLicense_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Engineering Diploma / Mühendislik Diploması";
            // 
            // rdCertificationNA
            // 
            this.rdCertificationNA.AutoSize = true;
            this.rdCertificationNA.Checked = true;
            this.rdCertificationNA.Location = new System.Drawing.Point(213, 18);
            this.rdCertificationNA.Name = "rdCertificationNA";
            this.rdCertificationNA.Size = new System.Drawing.Size(70, 17);
            this.rdCertificationNA.TabIndex = 1;
            this.rdCertificationNA.TabStop = true;
            this.rdCertificationNA.Text = "NA / Yok";
            this.rdCertificationNA.UseVisualStyleBackColor = true;
            this.rdCertificationNA.CheckedChanged += new System.EventHandler(this.rdCertificationNA_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Driving License / Ehliyet";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtEducationGPA);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtEducationGraduateFrom);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cboEducationLevel);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(13, 259);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(775, 65);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Education / Öğrenim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "out of 4";
            // 
            // txtEducationGPA
            // 
            this.txtEducationGPA.Location = new System.Drawing.Point(483, 31);
            this.txtEducationGPA.Name = "txtEducationGPA";
            this.txtEducationGPA.Size = new System.Drawing.Size(95, 20);
            this.txtEducationGPA.TabIndex = 5;
            this.txtEducationGPA.Validating += new System.ComponentModel.CancelEventHandler(this.txtEducationGPA_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(483, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "GPA / Ağırlıklı Not Ortalaması";
            // 
            // txtEducationGraduateFrom
            // 
            this.txtEducationGraduateFrom.Location = new System.Drawing.Point(173, 31);
            this.txtEducationGraduateFrom.Name = "txtEducationGraduateFrom";
            this.txtEducationGraduateFrom.Size = new System.Drawing.Size(304, 20);
            this.txtEducationGraduateFrom.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Graduate from / Mezun olunan yer";
            // 
            // cboEducationLevel
            // 
            this.cboEducationLevel.FormattingEnabled = true;
            this.cboEducationLevel.Items.AddRange(new object[] {
            "University / Üniversite",
            "MSc / Yüksek Lisan",
            "PhD / Doktora"});
            this.cboEducationLevel.Location = new System.Drawing.Point(10, 31);
            this.cboEducationLevel.Name = "cboEducationLevel";
            this.cboEducationLevel.Size = new System.Drawing.Size(159, 21);
            this.cboEducationLevel.TabIndex = 1;
            this.cboEducationLevel.Text = "High School / Lise";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Level / Derece";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbInterest);
            this.groupBox5.Location = new System.Drawing.Point(13, 372);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(248, 183);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Interest / İlgi Alanları";
            // 
            // lbInterest
            // 
            this.lbInterest.FormattingEnabled = true;
            this.lbInterest.Items.AddRange(new object[] {
            "Football / Futbol",
            "Basketball / Basketbol",
            "Volleyball / Voleybol",
            "Running / Koşu",
            "Other sports / Diğer sporlar",
            "Reading / Kitap okuma",
            "Writing / Yazı yazma",
            "Taking Photo / Fotoğraf çekme",
            "Play Instrument / Enstrüman çalma"});
            this.lbInterest.Location = new System.Drawing.Point(10, 19);
            this.lbInterest.Name = "lbInterest";
            this.lbInterest.Size = new System.Drawing.Size(227, 154);
            this.lbInterest.TabIndex = 6;
            // 
            // btnSendForm
            // 
            this.btnSendForm.Location = new System.Drawing.Point(485, 457);
            this.btnSendForm.Name = "btnSendForm";
            this.btnSendForm.Size = new System.Drawing.Size(303, 98);
            this.btnSendForm.TabIndex = 5;
            this.btnSendForm.Text = "Send Form / Formu Gönder";
            this.btnSendForm.UseVisualStyleBackColor = true;
            this.btnSendForm.Click += new System.EventHandler(this.btnSendForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 561);
            this.Controls.Add(this.btnSendForm);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(815, 600);
            this.MinimumSize = new System.Drawing.Size(815, 600);
            this.Name = "Form1";
            this.Text = "Job Application Form / İş Başvuru Formu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkJobTesting;
        private System.Windows.Forms.CheckBox chkJobAnalyst;
        private System.Windows.Forms.CheckBox chkJobMobile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboBirthPlace;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkDrivingLicenseH;
        private System.Windows.Forms.CheckBox chkDrivingLicenseA;
        private System.Windows.Forms.CheckBox chkDrivingLicenseE;
        private System.Windows.Forms.CheckBox chkEngineer;
        private System.Windows.Forms.CheckBox chkDrivingLicenseB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdCertificationNA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtEducationGPA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEducationGraduateFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboEducationLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSendForm;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.CheckedListBox lbInterest;
        private System.Windows.Forms.Label label6;
    }
}

