#region Usings
using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
#endregion

namespace Carm.Tg
{
    public partial class ListasDePrecios : DockContent
    {
        private TNGS.NetControls.XPanel xpnlBase;
        private TNGS.NetControls.GlassButton cmdSalir;
        private System.Windows.Forms.Label lblTitle;
        private TNGS.NetControls.GlassButton cmdExcel;
        private TNGS.NetControls.GlassButton cmdPrint;
        private TNGS.NetControls.GlassButton cmdNuevo;
        private TNGS.NetControls.GlassButton cmdModificar;
        private TNGS.NetControls.GlassButton cmdPurgar;
        private TNGS.NetControls.ImgGroup frmEdicion;
        private System.Windows.Forms.Label lblCod;
        private TNGS.NetControls.TextEdit txtCod;
        private System.Windows.Forms.Label lblDes;
        private TNGS.NetControls.TextEdit txtDes;
        private System.Windows.Forms.Label lblCodplan;
        private TNGS.NetControls.CDCombo cmbCodplan;
        private System.Windows.Forms.Label lblCodmarca;
        private TNGS.NetControls.CDCombo cmbCodmarca;
        private System.Windows.Forms.Label lblPrecio1p;
        private TNGS.NetControls.DecimalEdit txtPrecio1p;
        private System.Windows.Forms.Label lblPrecio2p;
        private TNGS.NetControls.DecimalEdit txtPrecio2p;
        private System.Windows.Forms.Label lblPrecio3p;
        private TNGS.NetControls.DecimalEdit txtPrecio3p;
        private System.Windows.Forms.Label lblPrecio4p;
        private TNGS.NetControls.DecimalEdit txtPrecio4p;
        private System.Windows.Forms.Label lblPrecio5p;
        private TNGS.NetControls.DecimalEdit txtPrecio5p;
        private System.Windows.Forms.Label lblPrecio6p;
        private TNGS.NetControls.DecimalEdit txtPrecio6p;
        private System.Windows.Forms.Label lblPrecio7p;
        private TNGS.NetControls.DecimalEdit txtPrecio7p;
        private System.Windows.Forms.Label lblPrecio8p;
        private TNGS.NetControls.DecimalEdit txtPrecio8p;
        private System.Windows.Forms.Label lblPrecio9p;
        private TNGS.NetControls.DecimalEdit txtPrecio9p;
        private System.Windows.Forms.Label lblPrecio10p;
        private TNGS.NetControls.DecimalEdit txtPrecio10p;
        private TNGS.NetControls.GlassButton cmdDesHab;
        private TNGS.NetControls.GlassButton cmdHab;
        private TNGS.NetControls.GlassButton cmdGrabar;
        private TNGS.NetControls.GlassButton cmdCancelar;
        private TNGS.NetControls.FullGrid grdDatos;
        private TNGS.NetControls.TSContainer tsContainer1;
        private RibbonStyle.TabPageSwitcher tabPageSwitcher1;
        private RibbonStyle.TabStripPage tabStripPage1;
        private TNGS.NetControls.TSPanel tsPanel2;
        private TNGS.NetControls.TSPanel tsPanel1;
        private TNGS.NetControls.TSBase tsBase1;
        private RibbonStyle.Tab tab1;

        /// <summary>
        /// Liberamos los recursos utilizados
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListasDePrecios));
            this.xpnlBase = new TNGS.NetControls.XPanel();
            this.tsContainer1 = new TNGS.NetControls.TSContainer();
            this.tabPageSwitcher1 = new RibbonStyle.TabPageSwitcher();
            this.tabStripPage1 = new RibbonStyle.TabStripPage();
            this.tsPanel2 = new TNGS.NetControls.TSPanel();
            this.cmdHab = new TNGS.NetControls.GlassButton();
            this.cmdCancelar = new TNGS.NetControls.GlassButton();
            this.cmdGrabar = new TNGS.NetControls.GlassButton();
            this.cmdDesHab = new TNGS.NetControls.GlassButton();
            this.tsPanel1 = new TNGS.NetControls.TSPanel();
            this.cmdSalir = new TNGS.NetControls.GlassButton();
            this.cmdPurgar = new TNGS.NetControls.GlassButton();
            this.cmdModificar = new TNGS.NetControls.GlassButton();
            this.cmdNuevo = new TNGS.NetControls.GlassButton();
            this.tsBase1 = new TNGS.NetControls.TSBase();
            this.tab1 = new RibbonStyle.Tab();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdDatos = new TNGS.NetControls.FullGrid();
            this.cmdPrint = new TNGS.NetControls.GlassButton();
            this.cmdExcel = new TNGS.NetControls.GlassButton();
            this.frmEdicion = new TNGS.NetControls.ImgGroup();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new TNGS.NetControls.TextEdit();
            this.lblDes = new System.Windows.Forms.Label();
            this.txtDes = new TNGS.NetControls.TextEdit();
            this.lblCodplan = new System.Windows.Forms.Label();
            this.cmbCodplan = new TNGS.NetControls.CDCombo();
            this.lblCodmarca = new System.Windows.Forms.Label();
            this.cmbCodmarca = new TNGS.NetControls.CDCombo();
            this.lblPrecio1p = new System.Windows.Forms.Label();
            this.txtPrecio1p = new TNGS.NetControls.DecimalEdit();
            this.lblPrecio2p = new System.Windows.Forms.Label();
            this.txtPrecio2p = new TNGS.NetControls.DecimalEdit();
            this.lblPrecio3p = new System.Windows.Forms.Label();
            this.txtPrecio3p = new TNGS.NetControls.DecimalEdit();
            this.lblPrecio4p = new System.Windows.Forms.Label();
            this.txtPrecio4p = new TNGS.NetControls.DecimalEdit();
            this.lblPrecio5p = new System.Windows.Forms.Label();
            this.txtPrecio5p = new TNGS.NetControls.DecimalEdit();
            this.lblPrecio6p = new System.Windows.Forms.Label();
            this.txtPrecio6p = new TNGS.NetControls.DecimalEdit();
            this.lblPrecio7p = new System.Windows.Forms.Label();
            this.txtPrecio7p = new TNGS.NetControls.DecimalEdit();
            this.lblPrecio8p = new System.Windows.Forms.Label();
            this.txtPrecio8p = new TNGS.NetControls.DecimalEdit();
            this.lblPrecio9p = new System.Windows.Forms.Label();
            this.txtPrecio9p = new TNGS.NetControls.DecimalEdit();
            this.lblPrecio10p = new System.Windows.Forms.Label();
            this.txtPrecio10p = new TNGS.NetControls.DecimalEdit();
            this.xpnlBase.SuspendLayout();
            this.tsContainer1.SuspendLayout();
            this.tabPageSwitcher1.SuspendLayout();
            this.tabStripPage1.SuspendLayout();
            this.tsPanel2.SuspendLayout();
            this.tsPanel1.SuspendLayout();
            this.tsBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.frmEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlBase
            // 
            this.xpnlBase.BackColor1 = System.Drawing.SystemColors.Control;
            this.xpnlBase.BackColor2 = System.Drawing.SystemColors.Control;
            this.xpnlBase.Controls.Add(this.tsContainer1);
            this.xpnlBase.Controls.Add(this.lblTitle);
            this.xpnlBase.Controls.Add(this.grdDatos);
            this.xpnlBase.Controls.Add(this.cmdPrint);
            this.xpnlBase.Controls.Add(this.cmdExcel);
            this.xpnlBase.Controls.Add(this.frmEdicion);
            this.xpnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlBase.Location = new System.Drawing.Point(0, 0);
            this.xpnlBase.Name = "xpnlBase";
            this.xpnlBase.Size = new System.Drawing.Size(1008, 629);
            this.xpnlBase.TabIndex = 0;
            // 
            // tsContainer1
            // 
            this.tsContainer1.Controls.Add(this.tabPageSwitcher1);
            this.tsContainer1.Controls.Add(this.tsBase1);
            this.tsContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsContainer1.Location = new System.Drawing.Point(0, 0);
            this.tsContainer1.Name = "tsContainer1";
            this.tsContainer1.Size = new System.Drawing.Size(1008, 115);
            this.tsContainer1.TabIndex = 22;
            // 
            // tabPageSwitcher1
            // 
            this.tabPageSwitcher1.Controls.Add(this.tabStripPage1);
            this.tabPageSwitcher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageSwitcher1.Location = new System.Drawing.Point(0, 26);
            this.tabPageSwitcher1.Name = "tabPageSwitcher1";
            this.tabPageSwitcher1.SelectedTabStripPage = this.tabStripPage1;
            this.tabPageSwitcher1.Size = new System.Drawing.Size(1008, 89);
            this.tabPageSwitcher1.TabIndex = 1;
            this.tabPageSwitcher1.TabStrip = this.tsBase1;
            this.tabPageSwitcher1.Text = "tabPageSwitcher1";
            // 
            // tabStripPage1
            // 
            this.tabStripPage1.Caption = "";
            this.tabStripPage1.Controls.Add(this.tsPanel2);
            this.tabStripPage1.Controls.Add(this.tsPanel1);
            this.tabStripPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStripPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabStripPage1.Location = new System.Drawing.Point(4, 0);
            this.tabStripPage1.Name = "tabStripPage1";
            this.tabStripPage1.Opacity = 255;
            this.tabStripPage1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tabStripPage1.Size = new System.Drawing.Size(1000, 87);
            this.tabStripPage1.Speed = 8;
            this.tabStripPage1.TabIndex = 0;
            // 
            // tsPanel2
            // 
            this.tsPanel2.Caption = "Edici�n";
            this.tsPanel2.Controls.Add(this.cmdHab);
            this.tsPanel2.Controls.Add(this.cmdCancelar);
            this.tsPanel2.Controls.Add(this.cmdGrabar);
            this.tsPanel2.Controls.Add(this.cmdDesHab);
            this.tsPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel2.FlatColor = System.Drawing.Color.RoyalBlue;
            this.tsPanel2.Location = new System.Drawing.Point(282, 3);
            this.tsPanel2.Name = "tsPanel2";
            this.tsPanel2.Opacity = 255;
            this.tsPanel2.Size = new System.Drawing.Size(284, 85);
            this.tsPanel2.Speed = 1;
            this.tsPanel2.TabIndex = 1;
            // 
            // cmdHab
            // 
            this.cmdHab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdHab.BackgroundImage")));
            this.cmdHab.BlackBorder = true;
            this.cmdHab.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdHab.CircleButton = false;
            this.cmdHab.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Check;
            this.cmdHab.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdHab.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.cmdHab.FlatFontSize = 9;
            this.cmdHab.FlatTextColor = System.Drawing.Color.Black;
            this.cmdHab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmdHab.Location = new System.Drawing.Point(157, 7);
            this.cmdHab.Name = "cmdHab";
            this.cmdHab.RoundCorners = 2;
            this.cmdHab.Size = new System.Drawing.Size(113, 25);
            this.cmdHab.TabIndex = 11;
            this.cmdHab.Text = "Habilitar";
            this.cmdHab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdHab.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdHab.Click += new System.EventHandler(this.cmdDesHab_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.BackgroundImage")));
            this.cmdCancelar.BlackBorder = true;
            this.cmdCancelar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdCancelar.CircleButton = false;
            this.cmdCancelar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Cancel;
            this.cmdCancelar.FlatColor = System.Drawing.Color.Red;
            this.cmdCancelar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.cmdCancelar.FlatFontSize = 9;
            this.cmdCancelar.FlatTextColor = System.Drawing.Color.Black;
            this.cmdCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmdCancelar.ImageOnTop = true;
            this.cmdCancelar.Location = new System.Drawing.Point(81, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.RoundCorners = 2;
            this.cmdCancelar.Size = new System.Drawing.Size(70, 60);
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCancelar.W8Color = System.Drawing.Color.Red;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdGrabar.BackgroundImage")));
            this.cmdGrabar.BlackBorder = true;
            this.cmdGrabar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdGrabar.CircleButton = false;
            this.cmdGrabar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Save;
            this.cmdGrabar.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdGrabar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.cmdGrabar.FlatFontSize = 9;
            this.cmdGrabar.FlatTextColor = System.Drawing.Color.Black;
            this.cmdGrabar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmdGrabar.ImageOnTop = true;
            this.cmdGrabar.Location = new System.Drawing.Point(8, 4);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.RoundCorners = 2;
            this.cmdGrabar.Size = new System.Drawing.Size(70, 60);
            this.cmdGrabar.TabIndex = 10;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdGrabar.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // cmdDesHab
            // 
            this.cmdDesHab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdDesHab.BackgroundImage")));
            this.cmdDesHab.BlackBorder = true;
            this.cmdDesHab.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdDesHab.CircleButton = false;
            this.cmdDesHab.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Block;
            this.cmdDesHab.FlatColor = System.Drawing.Color.Gold;
            this.cmdDesHab.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Yellow;
            this.cmdDesHab.FlatFontSize = 9;
            this.cmdDesHab.FlatTextColor = System.Drawing.Color.Black;
            this.cmdDesHab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmdDesHab.Location = new System.Drawing.Point(157, 35);
            this.cmdDesHab.Name = "cmdDesHab";
            this.cmdDesHab.RoundCorners = 2;
            this.cmdDesHab.Size = new System.Drawing.Size(113, 25);
            this.cmdDesHab.TabIndex = 11;
            this.cmdDesHab.Text = "Deshabilitar";
            this.cmdDesHab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDesHab.W8Color = System.Drawing.Color.Gold;
            this.cmdDesHab.Click += new System.EventHandler(this.cmdDesHab_Click);
            // 
            // tsPanel1
            // 
            this.tsPanel1.Caption = "Operaciones";
            this.tsPanel1.Controls.Add(this.cmdSalir);
            this.tsPanel1.Controls.Add(this.cmdPurgar);
            this.tsPanel1.Controls.Add(this.cmdModificar);
            this.tsPanel1.Controls.Add(this.cmdNuevo);
            this.tsPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel1.FlatColor = System.Drawing.Color.RoyalBlue;
            this.tsPanel1.Location = new System.Drawing.Point(0, 3);
            this.tsPanel1.Name = "tsPanel1";
            this.tsPanel1.Opacity = 255;
            this.tsPanel1.Size = new System.Drawing.Size(282, 85);
            this.tsPanel1.Speed = 1;
            this.tsPanel1.TabIndex = 0;
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdSalir.BackgroundImage")));
            this.cmdSalir.BlackBorder = true;
            this.cmdSalir.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdSalir.CircleButton = false;
            this.cmdSalir.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Undo;
            this.cmdSalir.FlatColor = System.Drawing.Color.Red;
            this.cmdSalir.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.cmdSalir.FlatFontSize = 9;
            this.cmdSalir.FlatTextColor = System.Drawing.Color.Black;
            this.cmdSalir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmdSalir.Location = new System.Drawing.Point(164, 7);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.RoundCorners = 2;
            this.cmdSalir.Size = new System.Drawing.Size(104, 25);
            this.cmdSalir.TabIndex = 6;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdSalir.W8Color = System.Drawing.Color.Red;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdPurgar
            // 
            this.cmdPurgar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdPurgar.BackgroundImage")));
            this.cmdPurgar.BlackBorder = true;
            this.cmdPurgar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdPurgar.CircleButton = false;
            this.cmdPurgar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Folder;
            this.cmdPurgar.FlatColor = System.Drawing.Color.Gray;
            this.cmdPurgar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Imprimir;
            this.cmdPurgar.FlatFontSize = 9;
            this.cmdPurgar.FlatTextColor = System.Drawing.Color.Black;
            this.cmdPurgar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmdPurgar.Location = new System.Drawing.Point(164, 35);
            this.cmdPurgar.Name = "cmdPurgar";
            this.cmdPurgar.RoundCorners = 2;
            this.cmdPurgar.Size = new System.Drawing.Size(104, 25);
            this.cmdPurgar.TabIndex = 5;
            this.cmdPurgar.Text = "Compactar";
            this.cmdPurgar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPurgar.W8Color = System.Drawing.Color.Gray;
            this.cmdPurgar.Click += new System.EventHandler(this.cmdPurgar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdModificar.BackgroundImage")));
            this.cmdModificar.BlackBorder = true;
            this.cmdModificar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdModificar.CircleButton = false;
            this.cmdModificar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Edit;
            this.cmdModificar.FlatColor = System.Drawing.Color.DodgerBlue;
            this.cmdModificar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.cmdModificar.FlatFontSize = 9;
            this.cmdModificar.FlatTextColor = System.Drawing.Color.Black;
            this.cmdModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmdModificar.ImageOnTop = true;
            this.cmdModificar.Location = new System.Drawing.Point(85, 4);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.RoundCorners = 2;
            this.cmdModificar.Size = new System.Drawing.Size(74, 60);
            this.cmdModificar.TabIndex = 4;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdModificar.W8Color = System.Drawing.Color.DodgerBlue;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdNuevo.BackgroundImage")));
            this.cmdNuevo.BlackBorder = true;
            this.cmdNuevo.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdNuevo.CircleButton = false;
            this.cmdNuevo.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.New;
            this.cmdNuevo.FlatColor = System.Drawing.Color.DodgerBlue;
            this.cmdNuevo.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.cmdNuevo.FlatFontSize = 9;
            this.cmdNuevo.FlatTextColor = System.Drawing.Color.Black;
            this.cmdNuevo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmdNuevo.ImageOnTop = true;
            this.cmdNuevo.Location = new System.Drawing.Point(8, 4);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.RoundCorners = 2;
            this.cmdNuevo.Size = new System.Drawing.Size(74, 60);
            this.cmdNuevo.TabIndex = 3;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdNuevo.W8Color = System.Drawing.Color.DodgerBlue;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // tsBase1
            // 
            this.tsBase1.AutoSize = false;
            this.tsBase1.FlatLigth = true;
            this.tsBase1.ForeColor = System.Drawing.Color.Black;
            this.tsBase1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBase1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsBase1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tab1});
            this.tsBase1.Location = new System.Drawing.Point(0, 0);
            this.tsBase1.Name = "tsBase1";
            this.tsBase1.Padding = new System.Windows.Forms.Padding(60, 3, 30, 0);
            this.tsBase1.SelectedTab = this.tab1;
            this.tsBase1.ShowItemToolTips = false;
            this.tsBase1.Size = new System.Drawing.Size(1008, 26);
            this.tsBase1.TabIndex = 0;
            this.tsBase1.TabOverlap = 0;
            this.tsBase1.Text = "tsBase1";
            // 
            // tab1
            // 
            this.tab1.AutoSize = false;
            this.tab1.Checked = true;
            this.tab1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tab1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tab1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(154)))));
            this.tab1.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(135, 23);
            this.tab1.TabStripPage = this.tabStripPage1;
            this.tab1.Text = "Mantenimiento";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(9, 126);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 16);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "ListasDePrecios:";
            // 
            // grdDatos
            // 
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grdDatos.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(206)))), ((int)(((byte)(72)))));
            this.grdDatos.CaptionVisible = false;
            this.grdDatos.DataMember = "";
            this.grdDatos.ExcelName = "Datos Exportados";
            this.grdDatos.ExcelTitle = "";
            this.grdDatos.GridOrder = "";
            this.grdDatos.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.grdDatos.Location = new System.Drawing.Point(4, 142);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(1000, 186);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.Advance += new TNGS.NetRoutines.AdvanceEventHandler(this.grdDatos_Advance);
            this.grdDatos.DataDClick += new TNGS.NetRoutines.DataDClickEventHandler(this.grdDatos_DataDClick);
            this.grdDatos.HeaderClick += new TNGS.NetRoutines.HeaderClickEventHandler(this.grdDatos_HeaderClick);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdPrint.BackgroundImage")));
            this.cmdPrint.BlackBorder = true;
            this.cmdPrint.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdPrint.CircleButton = false;
            this.cmdPrint.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fPrint;
            this.cmdPrint.FlatColor = System.Drawing.Color.Gray;
            this.cmdPrint.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Imprimir;
            this.cmdPrint.FlatFontSize = 9;
            this.cmdPrint.FlatTextColor = System.Drawing.Color.Black;
            this.cmdPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmdPrint.Location = new System.Drawing.Point(977, 118);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.PCode = "TNGS.PRINT";
            this.cmdPrint.RoundCorners = 2;
            this.cmdPrint.Size = new System.Drawing.Size(26, 24);
            this.cmdPrint.TabIndex = 2;
            this.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPrint.W8Color = System.Drawing.Color.Gray;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdExcel
            // 
            this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExcel.BackgroundImage")));
            this.cmdExcel.BlackBorder = true;
            this.cmdExcel.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdExcel.CircleButton = false;
            this.cmdExcel.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fExcel;
            this.cmdExcel.FlatColor = System.Drawing.Color.LimeGreen;
            this.cmdExcel.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Excel;
            this.cmdExcel.FlatFontSize = 9;
            this.cmdExcel.FlatTextColor = System.Drawing.Color.Black;
            this.cmdExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmdExcel.Location = new System.Drawing.Point(950, 118);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.PCode = "TNGS.EXCEL";
            this.cmdExcel.RoundCorners = 2;
            this.cmdExcel.Size = new System.Drawing.Size(26, 24);
            this.cmdExcel.TabIndex = 1;
            this.cmdExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExcel.W8Color = System.Drawing.Color.LimeGreen;
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // frmEdicion
            // 
            this.frmEdicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frmEdicion.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.frmEdicion.BackgroundGradientColor = System.Drawing.SystemColors.Control;
            this.frmEdicion.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.frmEdicion.BlackBorder = true;
            this.frmEdicion.BorderColor = System.Drawing.Color.Black;
            this.frmEdicion.BorderThickness = 1F;
            this.frmEdicion.Controls.Add(this.lblCod);
            this.frmEdicion.Controls.Add(this.txtCod);
            this.frmEdicion.Controls.Add(this.lblDes);
            this.frmEdicion.Controls.Add(this.txtDes);
            this.frmEdicion.Controls.Add(this.lblCodplan);
            this.frmEdicion.Controls.Add(this.cmbCodplan);
            this.frmEdicion.Controls.Add(this.lblCodmarca);
            this.frmEdicion.Controls.Add(this.cmbCodmarca);
            this.frmEdicion.Controls.Add(this.lblPrecio1p);
            this.frmEdicion.Controls.Add(this.txtPrecio1p);
            this.frmEdicion.Controls.Add(this.lblPrecio2p);
            this.frmEdicion.Controls.Add(this.txtPrecio2p);
            this.frmEdicion.Controls.Add(this.lblPrecio3p);
            this.frmEdicion.Controls.Add(this.txtPrecio3p);
            this.frmEdicion.Controls.Add(this.lblPrecio4p);
            this.frmEdicion.Controls.Add(this.txtPrecio4p);
            this.frmEdicion.Controls.Add(this.lblPrecio5p);
            this.frmEdicion.Controls.Add(this.txtPrecio5p);
            this.frmEdicion.Controls.Add(this.lblPrecio6p);
            this.frmEdicion.Controls.Add(this.txtPrecio6p);
            this.frmEdicion.Controls.Add(this.lblPrecio7p);
            this.frmEdicion.Controls.Add(this.txtPrecio7p);
            this.frmEdicion.Controls.Add(this.lblPrecio8p);
            this.frmEdicion.Controls.Add(this.txtPrecio8p);
            this.frmEdicion.Controls.Add(this.lblPrecio9p);
            this.frmEdicion.Controls.Add(this.txtPrecio9p);
            this.frmEdicion.Controls.Add(this.lblPrecio10p);
            this.frmEdicion.Controls.Add(this.txtPrecio10p);
            this.frmEdicion.CustomGroupBoxColor = System.Drawing.Color.White;
            this.frmEdicion.FlatMode = true;
            this.frmEdicion.FontTitle = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEdicion.ForeColor = System.Drawing.Color.Black;
            this.frmEdicion.GroupImage = null;
            this.frmEdicion.GroupTitle = " ListaDePrecios ";
            this.frmEdicion.Location = new System.Drawing.Point(4, 334);
            this.frmEdicion.Name = "frmEdicion";
            this.frmEdicion.Padding = new System.Windows.Forms.Padding(20);
            this.frmEdicion.PaintGroupBox = false;
            this.frmEdicion.RoundCorners = 4;
            this.frmEdicion.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmEdicion.ShadowControl = false;
            this.frmEdicion.ShadowThickness = 3;
            this.frmEdicion.Size = new System.Drawing.Size(1000, 291);
            this.frmEdicion.TabIndex = 21;
            this.frmEdicion.TitleBackground = System.Drawing.Color.DodgerBlue;
            this.frmEdicion.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.frmEdicion.TitleFontColor = System.Drawing.Color.White;
            // 
            // lblCod
            // 
            this.lblCod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(17, 66);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(104, 22);
            this.lblCod.TabIndex = 106;
            this.lblCod.Text = "C�digo:";
            this.lblCod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.SystemColors.Window;
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(135, 65);
            this.txtCod.MaxLength = 4;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(67, 26);
            this.txtCod.TabIndex = 6;
            // 
            // lblDes
            // 
            this.lblDes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(17, 110);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(104, 22);
            this.lblDes.TabIndex = 107;
            this.lblDes.Text = "Descripci�n:";
            this.lblDes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDes
            // 
            this.txtDes.BackColor = System.Drawing.SystemColors.Window;
            this.txtDes.Enabled = false;
            this.txtDes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(135, 109);
            this.txtDes.MaxLength = 30;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(219, 26);
            this.txtDes.TabIndex = 7;
            // 
            // lblCodplan
            // 
            this.lblCodplan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodplan.Location = new System.Drawing.Point(17, 162);
            this.lblCodplan.Name = "lblCodplan";
            this.lblCodplan.Size = new System.Drawing.Size(104, 22);
            this.lblCodplan.TabIndex = 108;
            this.lblCodplan.Text = "Plan:";
            this.lblCodplan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCodplan
            // 
            this.cmbCodplan.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCodplan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodplan.Enabled = false;
            this.cmbCodplan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCodplan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodplan.Location = new System.Drawing.Point(135, 161);
            this.cmbCodplan.Name = "cmbCodplan";
            this.cmbCodplan.Size = new System.Drawing.Size(219, 26);
            this.cmbCodplan.Sorted = true;
            this.cmbCodplan.TabIndex = 8;
            // 
            // lblCodmarca
            // 
            this.lblCodmarca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodmarca.Location = new System.Drawing.Point(17, 217);
            this.lblCodmarca.Name = "lblCodmarca";
            this.lblCodmarca.Size = new System.Drawing.Size(104, 22);
            this.lblCodmarca.TabIndex = 109;
            this.lblCodmarca.Text = "Marca:";
            this.lblCodmarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCodmarca
            // 
            this.cmbCodmarca.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCodmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodmarca.Enabled = false;
            this.cmbCodmarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCodmarca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodmarca.Location = new System.Drawing.Point(135, 216);
            this.cmbCodmarca.Name = "cmbCodmarca";
            this.cmbCodmarca.Size = new System.Drawing.Size(219, 26);
            this.cmbCodmarca.Sorted = true;
            this.cmbCodmarca.TabIndex = 9;
            // 
            // lblPrecio1p
            // 
            this.lblPrecio1p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio1p.Location = new System.Drawing.Point(456, 71);
            this.lblPrecio1p.Name = "lblPrecio1p";
            this.lblPrecio1p.Size = new System.Drawing.Size(104, 22);
            this.lblPrecio1p.TabIndex = 110;
            this.lblPrecio1p.Text = "Precio 1 P:";
            this.lblPrecio1p.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecio1p
            // 
            this.txtPrecio1p.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio1p.Enabled = false;
            this.txtPrecio1p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio1p.Location = new System.Drawing.Point(566, 70);
            this.txtPrecio1p.MaxLength = 10;
            this.txtPrecio1p.Name = "txtPrecio1p";
            this.txtPrecio1p.Size = new System.Drawing.Size(108, 26);
            this.txtPrecio1p.TabIndex = 10;
            this.txtPrecio1p.Text = "0.00";
            // 
            // lblPrecio2p
            // 
            this.lblPrecio2p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio2p.Location = new System.Drawing.Point(456, 108);
            this.lblPrecio2p.Name = "lblPrecio2p";
            this.lblPrecio2p.Size = new System.Drawing.Size(104, 22);
            this.lblPrecio2p.TabIndex = 111;
            this.lblPrecio2p.Text = "Precio 2 P:";
            this.lblPrecio2p.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecio2p
            // 
            this.txtPrecio2p.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio2p.Enabled = false;
            this.txtPrecio2p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio2p.Location = new System.Drawing.Point(566, 107);
            this.txtPrecio2p.MaxLength = 10;
            this.txtPrecio2p.Name = "txtPrecio2p";
            this.txtPrecio2p.Size = new System.Drawing.Size(108, 26);
            this.txtPrecio2p.TabIndex = 11;
            this.txtPrecio2p.Text = "0.00";
            // 
            // lblPrecio3p
            // 
            this.lblPrecio3p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio3p.Location = new System.Drawing.Point(456, 147);
            this.lblPrecio3p.Name = "lblPrecio3p";
            this.lblPrecio3p.Size = new System.Drawing.Size(104, 22);
            this.lblPrecio3p.TabIndex = 112;
            this.lblPrecio3p.Text = "Precio 3 P:";
            this.lblPrecio3p.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecio3p
            // 
            this.txtPrecio3p.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio3p.Enabled = false;
            this.txtPrecio3p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio3p.Location = new System.Drawing.Point(566, 146);
            this.txtPrecio3p.MaxLength = 10;
            this.txtPrecio3p.Name = "txtPrecio3p";
            this.txtPrecio3p.Size = new System.Drawing.Size(108, 26);
            this.txtPrecio3p.TabIndex = 12;
            this.txtPrecio3p.Text = "0.00";
            // 
            // lblPrecio4p
            // 
            this.lblPrecio4p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio4p.Location = new System.Drawing.Point(456, 187);
            this.lblPrecio4p.Name = "lblPrecio4p";
            this.lblPrecio4p.Size = new System.Drawing.Size(104, 22);
            this.lblPrecio4p.TabIndex = 113;
            this.lblPrecio4p.Text = "Precio 4 P:";
            this.lblPrecio4p.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecio4p
            // 
            this.txtPrecio4p.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio4p.Enabled = false;
            this.txtPrecio4p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio4p.Location = new System.Drawing.Point(566, 186);
            this.txtPrecio4p.MaxLength = 10;
            this.txtPrecio4p.Name = "txtPrecio4p";
            this.txtPrecio4p.Size = new System.Drawing.Size(108, 26);
            this.txtPrecio4p.TabIndex = 13;
            this.txtPrecio4p.Text = "0.00";
            // 
            // lblPrecio5p
            // 
            this.lblPrecio5p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio5p.Location = new System.Drawing.Point(456, 226);
            this.lblPrecio5p.Name = "lblPrecio5p";
            this.lblPrecio5p.Size = new System.Drawing.Size(104, 22);
            this.lblPrecio5p.TabIndex = 114;
            this.lblPrecio5p.Text = "Precio 5 P:";
            this.lblPrecio5p.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecio5p
            // 
            this.txtPrecio5p.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio5p.Enabled = false;
            this.txtPrecio5p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio5p.Location = new System.Drawing.Point(566, 225);
            this.txtPrecio5p.MaxLength = 10;
            this.txtPrecio5p.Name = "txtPrecio5p";
            this.txtPrecio5p.Size = new System.Drawing.Size(108, 26);
            this.txtPrecio5p.TabIndex = 14;
            this.txtPrecio5p.Text = "0.00";
            // 
            // lblPrecio6p
            // 
            this.lblPrecio6p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio6p.Location = new System.Drawing.Point(731, 70);
            this.lblPrecio6p.Name = "lblPrecio6p";
            this.lblPrecio6p.Size = new System.Drawing.Size(104, 22);
            this.lblPrecio6p.TabIndex = 115;
            this.lblPrecio6p.Text = "Precio 6 P:";
            this.lblPrecio6p.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecio6p
            // 
            this.txtPrecio6p.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio6p.Enabled = false;
            this.txtPrecio6p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio6p.Location = new System.Drawing.Point(841, 69);
            this.txtPrecio6p.MaxLength = 10;
            this.txtPrecio6p.Name = "txtPrecio6p";
            this.txtPrecio6p.Size = new System.Drawing.Size(125, 26);
            this.txtPrecio6p.TabIndex = 15;
            this.txtPrecio6p.Text = "0.00";
            // 
            // lblPrecio7p
            // 
            this.lblPrecio7p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio7p.Location = new System.Drawing.Point(731, 111);
            this.lblPrecio7p.Name = "lblPrecio7p";
            this.lblPrecio7p.Size = new System.Drawing.Size(104, 22);
            this.lblPrecio7p.TabIndex = 116;
            this.lblPrecio7p.Text = "Precio 7 P:";
            this.lblPrecio7p.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecio7p
            // 
            this.txtPrecio7p.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio7p.Enabled = false;
            this.txtPrecio7p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio7p.Location = new System.Drawing.Point(841, 110);
            this.txtPrecio7p.MaxLength = 10;
            this.txtPrecio7p.Name = "txtPrecio7p";
            this.txtPrecio7p.Size = new System.Drawing.Size(125, 26);
            this.txtPrecio7p.TabIndex = 16;
            this.txtPrecio7p.Text = "0.00";
            // 
            // lblPrecio8p
            // 
            this.lblPrecio8p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio8p.Location = new System.Drawing.Point(731, 150);
            this.lblPrecio8p.Name = "lblPrecio8p";
            this.lblPrecio8p.Size = new System.Drawing.Size(104, 22);
            this.lblPrecio8p.TabIndex = 117;
            this.lblPrecio8p.Text = "Precio 8 P:";
            this.lblPrecio8p.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecio8p
            // 
            this.txtPrecio8p.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio8p.Enabled = false;
            this.txtPrecio8p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio8p.Location = new System.Drawing.Point(841, 149);
            this.txtPrecio8p.MaxLength = 10;
            this.txtPrecio8p.Name = "txtPrecio8p";
            this.txtPrecio8p.Size = new System.Drawing.Size(125, 26);
            this.txtPrecio8p.TabIndex = 17;
            this.txtPrecio8p.Text = "0.00";
            // 
            // lblPrecio9p
            // 
            this.lblPrecio9p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio9p.Location = new System.Drawing.Point(731, 190);
            this.lblPrecio9p.Name = "lblPrecio9p";
            this.lblPrecio9p.Size = new System.Drawing.Size(104, 22);
            this.lblPrecio9p.TabIndex = 118;
            this.lblPrecio9p.Text = "Precio 9 P:";
            this.lblPrecio9p.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecio9p
            // 
            this.txtPrecio9p.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio9p.Enabled = false;
            this.txtPrecio9p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio9p.Location = new System.Drawing.Point(841, 189);
            this.txtPrecio9p.MaxLength = 10;
            this.txtPrecio9p.Name = "txtPrecio9p";
            this.txtPrecio9p.Size = new System.Drawing.Size(125, 26);
            this.txtPrecio9p.TabIndex = 18;
            this.txtPrecio9p.Text = "0.00";
            // 
            // lblPrecio10p
            // 
            this.lblPrecio10p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio10p.Location = new System.Drawing.Point(731, 228);
            this.lblPrecio10p.Name = "lblPrecio10p";
            this.lblPrecio10p.Size = new System.Drawing.Size(104, 22);
            this.lblPrecio10p.TabIndex = 119;
            this.lblPrecio10p.Text = "Precio 10 P:";
            this.lblPrecio10p.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecio10p
            // 
            this.txtPrecio10p.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio10p.Enabled = false;
            this.txtPrecio10p.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio10p.Location = new System.Drawing.Point(841, 227);
            this.txtPrecio10p.MaxLength = 10;
            this.txtPrecio10p.Name = "txtPrecio10p";
            this.txtPrecio10p.Size = new System.Drawing.Size(125, 26);
            this.txtPrecio10p.TabIndex = 19;
            this.txtPrecio10p.Text = "0.00";
            // 
            // ListasDePrecios
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 629);
            this.Controls.Add(this.xpnlBase);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListasDePrecios";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TabText = "Mantenimiento de ListasDePrecios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListasDePrecios_FormClosed);
            this.Load += new System.EventHandler(this.ListasDePrecios_Load);
            this.xpnlBase.ResumeLayout(false);
            this.tsContainer1.ResumeLayout(false);
            this.tabPageSwitcher1.ResumeLayout(false);
            this.tabStripPage1.ResumeLayout(false);
            this.tsPanel2.ResumeLayout(false);
            this.tsPanel1.ResumeLayout(false);
            this.tsBase1.ResumeLayout(false);
            this.tsBase1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.frmEdicion.ResumeLayout(false);
            this.frmEdicion.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private IContainer components;
    }
}
