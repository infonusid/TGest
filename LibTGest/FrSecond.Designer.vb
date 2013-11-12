<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrSecond
    Inherits LibTGest.FrFirst
    'Inherits System.Windows.Forms.Form


    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrSecond))
        Me.pnlSup = New System.Windows.Forms.Panel()
        Me.pnlNav = New System.Windows.Forms.Panel()
        Me.pnlNavRight = New System.Windows.Forms.Panel()
        Me.pnlNavLeft = New System.Windows.Forms.Panel()
        Me.bn = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bnAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.bnCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.bnDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.bnMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.bnMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.bnSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.bnPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.bnSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bnMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.bnMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.bnSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.bnEdit = New System.Windows.Forms.ToolStripButton()
        Me.bnLoad = New System.Windows.Forms.ToolStripButton()
        Me.bnSave = New System.Windows.Forms.ToolStripButton()
        Me.bnCancel = New System.Windows.Forms.ToolStripButton()
        Me.bnSearch = New System.Windows.Forms.ToolStripButton()
        Me.bnPrint = New System.Windows.Forms.ToolStripButton()
        Me.bnPrint_Preview = New System.Windows.Forms.ToolStripButton()
        Me.bnGlobalView = New System.Windows.Forms.ToolStripButton()
        Me.bnDuplicateRecord = New System.Windows.Forms.ToolStripButton()
        Me.bnReportList = New System.Windows.Forms.ToolStripButton()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.ms = New System.Windows.Forms.MenuStrip()
        Me.msFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.msFPrintersetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.msFExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.msView = New System.Windows.Forms.ToolStripMenuItem()
        Me.msVGlobalView = New System.Windows.Forms.ToolStripMenuItem()
        Me.msRecord = New System.Windows.Forms.ToolStripMenuItem()
        Me.msRFirst = New System.Windows.Forms.ToolStripMenuItem()
        Me.msRPrevious = New System.Windows.Forms.ToolStripMenuItem()
        Me.msRNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.msRNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.msRLast = New System.Windows.Forms.ToolStripMenuItem()
        Me.msRDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.msLinea = New System.Windows.Forms.ToolStripSeparator()
        Me.msRSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.msReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.msRList = New System.Windows.Forms.ToolStripMenuItem()
        Me.msHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.msHSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.msHIndex = New System.Windows.Forms.ToolStripMenuItem()
        Me.msHContents = New System.Windows.Forms.ToolStripMenuItem()
        Me.msHAboutThis = New System.Windows.Forms.ToolStripMenuItem()
        Me.msTranslation = New System.Windows.Forms.ToolStripMenuItem()
        Me.msTTranslation = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlFill = New System.Windows.Forms.Panel()
        Me.tbc = New System.Windows.Forms.TabControl()
        Me.tbpDetail = New System.Windows.Forms.TabPage()
        Me.tbpList = New System.Windows.Forms.TabPage()
        Me.dgvNPrin = New System.Windows.Forms.DataGridView()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlSup.SuspendLayout()
        Me.pnlNav.SuspendLayout()
        Me.pnlNavLeft.SuspendLayout()
        CType(Me.bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bn.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.ms.SuspendLayout()
        Me.pnlFill.SuspendLayout()
        Me.tbc.SuspendLayout()
        Me.tbpList.SuspendLayout()
        CType(Me.dgvNPrin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSup
        '
        Me.pnlSup.Controls.Add(Me.pnlNav)
        Me.pnlSup.Controls.Add(Me.pnlMenu)
        Me.pnlSup.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSup.Location = New System.Drawing.Point(0, 0)
        Me.pnlSup.Name = "pnlSup"
        Me.pnlSup.Size = New System.Drawing.Size(1280, 52)
        Me.pnlSup.TabIndex = 1
        '
        'pnlNav
        '
        Me.pnlNav.Controls.Add(Me.pnlNavRight)
        Me.pnlNav.Controls.Add(Me.pnlNavLeft)
        Me.pnlNav.Location = New System.Drawing.Point(0, 26)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(780, 26)
        Me.pnlNav.TabIndex = 1
        '
        'pnlNavRight
        '
        Me.pnlNavRight.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNavRight.Location = New System.Drawing.Point(501, 0)
        Me.pnlNavRight.Name = "pnlNavRight"
        Me.pnlNavRight.Size = New System.Drawing.Size(268, 26)
        Me.pnlNavRight.TabIndex = 1
        '
        'pnlNavLeft
        '
        Me.pnlNavLeft.Controls.Add(Me.bn)
        Me.pnlNavLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNavLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlNavLeft.Name = "pnlNavLeft"
        Me.pnlNavLeft.Size = New System.Drawing.Size(501, 26)
        Me.pnlNavLeft.TabIndex = 0
        '
        'bn
        '
        Me.bn.AddNewItem = Me.bnAddNewItem
        Me.bn.CountItem = Me.bnCountItem
        Me.bn.DeleteItem = Me.bnDeleteItem
        Me.bn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bnMoveFirstItem, Me.bnMovePreviousItem, Me.bnSeparator, Me.bnPositionItem, Me.bnCountItem, Me.bnSeparator1, Me.bnMoveNextItem, Me.bnMoveLastItem, Me.bnSeparator2, Me.bnEdit, Me.bnAddNewItem, Me.bnDeleteItem, Me.bnLoad, Me.bnSave, Me.bnCancel, Me.bnSearch, Me.bnPrint, Me.bnPrint_Preview, Me.bnGlobalView, Me.bnDuplicateRecord, Me.bnReportList})
        Me.bn.Location = New System.Drawing.Point(0, 0)
        Me.bn.MoveFirstItem = Me.bnMoveFirstItem
        Me.bn.MoveLastItem = Me.bnMoveLastItem
        Me.bn.MoveNextItem = Me.bnMoveNextItem
        Me.bn.MovePreviousItem = Me.bnMovePreviousItem
        Me.bn.Name = "bn"
        Me.bn.PositionItem = Me.bnPositionItem
        Me.bn.Size = New System.Drawing.Size(501, 26)
        Me.bn.TabIndex = 2
        Me.bn.Text = "bn"
        '
        'bnAddNewItem
        '
        Me.bnAddNewItem.CheckOnClick = True
        Me.bnAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnAddNewItem.Image = CType(resources.GetObject("bnAddNewItem.Image"), System.Drawing.Image)
        Me.bnAddNewItem.Name = "bnAddNewItem"
        Me.bnAddNewItem.RightToLeftAutoMirrorImage = True
        Me.bnAddNewItem.Size = New System.Drawing.Size(23, 23)
        Me.bnAddNewItem.Text = "Add New Item"
        '
        'bnCountItem
        '
        Me.bnCountItem.Name = "bnCountItem"
        Me.bnCountItem.Size = New System.Drawing.Size(37, 23)
        Me.bnCountItem.Text = "de {0}"
        Me.bnCountItem.ToolTipText = "Total Count Item"
        '
        'bnDeleteItem
        '
        Me.bnDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnDeleteItem.Image = CType(resources.GetObject("bnDeleteItem.Image"), System.Drawing.Image)
        Me.bnDeleteItem.Name = "bnDeleteItem"
        Me.bnDeleteItem.RightToLeftAutoMirrorImage = True
        Me.bnDeleteItem.Size = New System.Drawing.Size(23, 23)
        Me.bnDeleteItem.Text = "Delete Item"
        '
        'bnMoveFirstItem
        '
        Me.bnMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnMoveFirstItem.Image = CType(resources.GetObject("bnMoveFirstItem.Image"), System.Drawing.Image)
        Me.bnMoveFirstItem.Name = "bnMoveFirstItem"
        Me.bnMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.bnMoveFirstItem.Size = New System.Drawing.Size(23, 23)
        Me.bnMoveFirstItem.Text = "Move First"
        '
        'bnMovePreviousItem
        '
        Me.bnMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnMovePreviousItem.Image = CType(resources.GetObject("bnMovePreviousItem.Image"), System.Drawing.Image)
        Me.bnMovePreviousItem.Name = "bnMovePreviousItem"
        Me.bnMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.bnMovePreviousItem.Size = New System.Drawing.Size(23, 23)
        Me.bnMovePreviousItem.Text = "Move Previous"
        '
        'bnSeparator
        '
        Me.bnSeparator.Name = "bnSeparator"
        Me.bnSeparator.Size = New System.Drawing.Size(6, 26)
        '
        'bnPositionItem
        '
        Me.bnPositionItem.AccessibleName = "Posición"
        Me.bnPositionItem.AutoSize = False
        Me.bnPositionItem.Name = "bnPositionItem"
        Me.bnPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.bnPositionItem.Text = "0"
        Me.bnPositionItem.ToolTipText = "Position Item"
        '
        'bnSeparator1
        '
        Me.bnSeparator1.Name = "bnSeparator1"
        Me.bnSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'bnMoveNextItem
        '
        Me.bnMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnMoveNextItem.Image = CType(resources.GetObject("bnMoveNextItem.Image"), System.Drawing.Image)
        Me.bnMoveNextItem.Name = "bnMoveNextItem"
        Me.bnMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.bnMoveNextItem.Size = New System.Drawing.Size(23, 23)
        Me.bnMoveNextItem.Text = "Move Next"
        '
        'bnMoveLastItem
        '
        Me.bnMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnMoveLastItem.Image = CType(resources.GetObject("bnMoveLastItem.Image"), System.Drawing.Image)
        Me.bnMoveLastItem.Name = "bnMoveLastItem"
        Me.bnMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.bnMoveLastItem.Size = New System.Drawing.Size(23, 23)
        Me.bnMoveLastItem.Text = "Move Last"
        '
        'bnSeparator2
        '
        Me.bnSeparator2.Name = "bnSeparator2"
        Me.bnSeparator2.Size = New System.Drawing.Size(6, 26)
        '
        'bnEdit
        '
        Me.bnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnEdit.Image = Global.LibTGest.My.Resources.Resources.lapiz
        Me.bnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnEdit.Name = "bnEdit"
        Me.bnEdit.Size = New System.Drawing.Size(23, 23)
        Me.bnEdit.Text = "toolStripButton1"
        '
        'bnLoad
        '
        Me.bnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnLoad.Image = Global.LibTGest.My.Resources.Resources.actualizar
        Me.bnLoad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnLoad.Name = "bnLoad"
        Me.bnLoad.Size = New System.Drawing.Size(23, 23)
        Me.bnLoad.Text = "Refresh"
        '
        'bnSave
        '
        Me.bnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnSave.Image = Global.LibTGest.My.Resources.Resources.grabar
        Me.bnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnSave.Name = "bnSave"
        Me.bnSave.Size = New System.Drawing.Size(23, 23)
        Me.bnSave.Text = "Save"
        '
        'bnCancel
        '
        Me.bnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnCancel.Image = CType(resources.GetObject("bnCancel.Image"), System.Drawing.Image)
        Me.bnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnCancel.Name = "bnCancel"
        Me.bnCancel.Size = New System.Drawing.Size(23, 23)
        Me.bnCancel.Text = "Cancel"
        '
        'bnSearch
        '
        Me.bnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnSearch.Image = CType(resources.GetObject("bnSearch.Image"), System.Drawing.Image)
        Me.bnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnSearch.Name = "bnSearch"
        Me.bnSearch.Size = New System.Drawing.Size(23, 23)
        Me.bnSearch.Text = "Search"
        '
        'bnPrint
        '
        Me.bnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnPrint.Image = Global.LibTGest.My.Resources.Resources.imprimir
        Me.bnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnPrint.Name = "bnPrint"
        Me.bnPrint.Size = New System.Drawing.Size(23, 23)
        Me.bnPrint.Text = "Print"
        '
        'bnPrint_Preview
        '
        Me.bnPrint_Preview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnPrint_Preview.Image = CType(resources.GetObject("bnPrint_Preview.Image"), System.Drawing.Image)
        Me.bnPrint_Preview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnPrint_Preview.Name = "bnPrint_Preview"
        Me.bnPrint_Preview.Size = New System.Drawing.Size(23, 23)
        Me.bnPrint_Preview.Tag = ""
        Me.bnPrint_Preview.Text = "Print preview"
        '
        'bnGlobalView
        '
        Me.bnGlobalView.CheckOnClick = True
        Me.bnGlobalView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnGlobalView.Image = CType(resources.GetObject("bnGlobalView.Image"), System.Drawing.Image)
        Me.bnGlobalView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnGlobalView.Name = "bnGlobalView"
        Me.bnGlobalView.Size = New System.Drawing.Size(23, 23)
        Me.bnGlobalView.Text = "Global View"
        '
        'bnDuplicateRecord
        '
        Me.bnDuplicateRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnDuplicateRecord.Image = CType(resources.GetObject("bnDuplicateRecord.Image"), System.Drawing.Image)
        Me.bnDuplicateRecord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnDuplicateRecord.Name = "bnDuplicateRecord"
        Me.bnDuplicateRecord.Size = New System.Drawing.Size(23, 23)
        Me.bnDuplicateRecord.Text = "DuplicateRecord"
        '
        'bnReportList
        '
        Me.bnReportList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnReportList.Image = CType(resources.GetObject("bnReportList.Image"), System.Drawing.Image)
        Me.bnReportList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnReportList.Name = "bnReportList"
        Me.bnReportList.Size = New System.Drawing.Size(23, 23)
        Me.bnReportList.Text = "ReportList"
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.ms)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(1280, 26)
        Me.pnlMenu.TabIndex = 0
        '
        'ms
        '
        Me.ms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msFile, Me.msView, Me.msRecord, Me.msReport, Me.msHelp, Me.msTranslation})
        Me.ms.Location = New System.Drawing.Point(0, 0)
        Me.ms.Name = "ms"
        Me.ms.Size = New System.Drawing.Size(1280, 24)
        Me.ms.TabIndex = 4
        Me.ms.Text = "menuSS"
        '
        'msFile
        '
        Me.msFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msFPrintersetup, Me.msFExit})
        Me.msFile.Name = "msFile"
        Me.msFile.Size = New System.Drawing.Size(37, 20)
        Me.msFile.Text = "File"
        '
        'msFPrintersetup
        '
        Me.msFPrintersetup.Name = "msFPrintersetup"
        Me.msFPrintersetup.Size = New System.Drawing.Size(142, 22)
        Me.msFPrintersetup.Text = "Printer Setup"
        '
        'msFExit
        '
        Me.msFExit.Name = "msFExit"
        Me.msFExit.Size = New System.Drawing.Size(142, 22)
        Me.msFExit.Text = "Exit"
        '
        'msView
        '
        Me.msView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msVGlobalView})
        Me.msView.Name = "msView"
        Me.msView.Size = New System.Drawing.Size(44, 20)
        Me.msView.Text = "View"
        '
        'msVGlobalView
        '
        Me.msVGlobalView.CheckOnClick = True
        Me.msVGlobalView.Name = "msVGlobalView"
        Me.msVGlobalView.Size = New System.Drawing.Size(136, 22)
        Me.msVGlobalView.Text = "Global View"
        '
        'msRecord
        '
        Me.msRecord.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msRFirst, Me.msRPrevious, Me.msRNext, Me.msRNew, Me.msRLast, Me.msRDelete, Me.msLinea, Me.msRSearch})
        Me.msRecord.Name = "msRecord"
        Me.msRecord.Size = New System.Drawing.Size(56, 20)
        Me.msRecord.Text = "Record"
        '
        'msRFirst
        '
        Me.msRFirst.Name = "msRFirst"
        Me.msRFirst.Size = New System.Drawing.Size(119, 22)
        Me.msRFirst.Text = "First"
        '
        'msRPrevious
        '
        Me.msRPrevious.Name = "msRPrevious"
        Me.msRPrevious.Size = New System.Drawing.Size(119, 22)
        Me.msRPrevious.Text = "Previous"
        '
        'msRNext
        '
        Me.msRNext.Name = "msRNext"
        Me.msRNext.Size = New System.Drawing.Size(119, 22)
        Me.msRNext.Text = "Next"
        '
        'msRNew
        '
        Me.msRNew.Name = "msRNew"
        Me.msRNew.Size = New System.Drawing.Size(119, 22)
        Me.msRNew.Text = "New"
        '
        'msRLast
        '
        Me.msRLast.Name = "msRLast"
        Me.msRLast.Size = New System.Drawing.Size(119, 22)
        Me.msRLast.Text = "Last"
        '
        'msRDelete
        '
        Me.msRDelete.Name = "msRDelete"
        Me.msRDelete.Size = New System.Drawing.Size(119, 22)
        Me.msRDelete.Text = "Delete"
        '
        'msLinea
        '
        Me.msLinea.Name = "msLinea"
        Me.msLinea.Size = New System.Drawing.Size(116, 6)
        '
        'msRSearch
        '
        Me.msRSearch.Name = "msRSearch"
        Me.msRSearch.Size = New System.Drawing.Size(119, 22)
        Me.msRSearch.Text = "Search"
        '
        'msReport
        '
        Me.msReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msRList})
        Me.msReport.Name = "msReport"
        Me.msReport.Size = New System.Drawing.Size(54, 20)
        Me.msReport.Text = "Report"
        '
        'msRList
        '
        Me.msRList.Name = "msRList"
        Me.msRList.Size = New System.Drawing.Size(92, 22)
        Me.msRList.Text = "List"
        '
        'msHelp
        '
        Me.msHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msHSearch, Me.msHIndex, Me.msHContents, Me.msHAboutThis})
        Me.msHelp.Name = "msHelp"
        Me.msHelp.Size = New System.Drawing.Size(44, 20)
        Me.msHelp.Text = "Help"
        '
        'msHSearch
        '
        Me.msHSearch.Name = "msHSearch"
        Me.msHSearch.Size = New System.Drawing.Size(129, 22)
        Me.msHSearch.Text = "Search"
        '
        'msHIndex
        '
        Me.msHIndex.Name = "msHIndex"
        Me.msHIndex.Size = New System.Drawing.Size(129, 22)
        Me.msHIndex.Text = "Index"
        '
        'msHContents
        '
        Me.msHContents.Name = "msHContents"
        Me.msHContents.Size = New System.Drawing.Size(129, 22)
        Me.msHContents.Text = "Contents"
        '
        'msHAboutThis
        '
        Me.msHAboutThis.Name = "msHAboutThis"
        Me.msHAboutThis.Size = New System.Drawing.Size(129, 22)
        Me.msHAboutThis.Text = "About this"
        '
        'msTranslation
        '
        Me.msTranslation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msTTranslation})
        Me.msTranslation.Name = "msTranslation"
        Me.msTranslation.Size = New System.Drawing.Size(78, 20)
        Me.msTranslation.Text = "Translation"
        '
        'msTTranslation
        '
        Me.msTTranslation.Name = "msTTranslation"
        Me.msTTranslation.Size = New System.Drawing.Size(133, 22)
        Me.msTTranslation.Text = "Translation"
        '
        'pnlFill
        '
        Me.pnlFill.Controls.Add(Me.tbc)
        Me.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFill.Location = New System.Drawing.Point(0, 52)
        Me.pnlFill.Name = "pnlFill"
        Me.pnlFill.Size = New System.Drawing.Size(1280, 748)
        Me.pnlFill.TabIndex = 2
        '
        'tbc
        '
        Me.tbc.Controls.Add(Me.tbpDetail)
        Me.tbc.Controls.Add(Me.tbpList)
        Me.tbc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbc.Location = New System.Drawing.Point(0, 0)
        Me.tbc.Name = "tbc"
        Me.tbc.SelectedIndex = 0
        Me.tbc.Size = New System.Drawing.Size(1280, 748)
        Me.tbc.TabIndex = 0
        '
        'tbpDetail
        '
        Me.tbpDetail.BackColor = System.Drawing.Color.Transparent
        Me.tbpDetail.Location = New System.Drawing.Point(4, 22)
        Me.tbpDetail.Name = "tbpDetail"
        Me.tbpDetail.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDetail.Size = New System.Drawing.Size(1272, 722)
        Me.tbpDetail.TabIndex = 0
        Me.tbpDetail.Text = "tbpDetail"
        '
        'tbpList
        '
        Me.tbpList.Controls.Add(Me.dgvNPrin)
        Me.tbpList.Location = New System.Drawing.Point(4, 22)
        Me.tbpList.Name = "tbpList"
        Me.tbpList.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpList.Size = New System.Drawing.Size(1272, 722)
        Me.tbpList.TabIndex = 1
        Me.tbpList.Text = "tbpList"
        Me.tbpList.UseVisualStyleBackColor = True
        '
        'dgvNPrin
        '
        Me.dgvNPrin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNPrin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNPrin.Location = New System.Drawing.Point(3, 3)
        Me.dgvNPrin.Name = "dgvNPrin"
        Me.dgvNPrin.Size = New System.Drawing.Size(1266, 716)
        Me.dgvNPrin.TabIndex = 1
        '
        'FrSecond
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 800)
        Me.Controls.Add(Me.pnlFill)
        Me.Controls.Add(Me.pnlSup)
        Me.Name = "FrSecond"
        Me.Text = "FrSecond"
        Me.pnlSup.ResumeLayout(False)
        Me.pnlNav.ResumeLayout(False)
        Me.pnlNavLeft.ResumeLayout(False)
        Me.pnlNavLeft.PerformLayout()
        CType(Me.bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bn.ResumeLayout(False)
        Me.bn.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.ms.ResumeLayout(False)
        Me.ms.PerformLayout()
        Me.pnlFill.ResumeLayout(False)
        Me.tbc.ResumeLayout(False)
        Me.tbpList.ResumeLayout(False)
        CType(Me.dgvNPrin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents pnlSup As System.Windows.Forms.Panel
    Public WithEvents pnlNav As System.Windows.Forms.Panel
    Private WithEvents pnlNavRight As System.Windows.Forms.Panel
    Private WithEvents pnlNavLeft As System.Windows.Forms.Panel
    Public WithEvents bn As System.Windows.Forms.BindingNavigator
    Protected WithEvents bnAddNewItem As System.Windows.Forms.ToolStripButton
    Protected WithEvents bnCountItem As System.Windows.Forms.ToolStripLabel
    Protected WithEvents bnDeleteItem As System.Windows.Forms.ToolStripButton
    Protected WithEvents bnMoveFirstItem As System.Windows.Forms.ToolStripButton
    Protected WithEvents bnMovePreviousItem As System.Windows.Forms.ToolStripButton
    Public WithEvents bnSeparator As System.Windows.Forms.ToolStripSeparator
    Protected WithEvents bnPositionItem As System.Windows.Forms.ToolStripTextBox
    Public WithEvents bnSeparator1 As System.Windows.Forms.ToolStripSeparator
    Protected WithEvents bnMoveNextItem As System.Windows.Forms.ToolStripButton
    Protected WithEvents bnMoveLastItem As System.Windows.Forms.ToolStripButton
    Public WithEvents bnSeparator2 As System.Windows.Forms.ToolStripSeparator
    Protected WithEvents bnEdit As System.Windows.Forms.ToolStripButton
    Protected WithEvents bnLoad As System.Windows.Forms.ToolStripButton
    Protected WithEvents bnSave As System.Windows.Forms.ToolStripButton
    Protected WithEvents bnCancel As System.Windows.Forms.ToolStripButton
    Protected WithEvents bnSearch As System.Windows.Forms.ToolStripButton
    Protected WithEvents bnPrint As System.Windows.Forms.ToolStripButton
    Protected WithEvents bnPrint_Preview As System.Windows.Forms.ToolStripButton
    Protected WithEvents bnGlobalView As System.Windows.Forms.ToolStripButton
    Protected WithEvents bnDuplicateRecord As System.Windows.Forms.ToolStripButton
    Protected WithEvents bnReportList As System.Windows.Forms.ToolStripButton
    Public WithEvents pnlMenu As System.Windows.Forms.Panel
    Protected WithEvents ms As System.Windows.Forms.MenuStrip
    Protected WithEvents msFile As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msFPrintersetup As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msFExit As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msView As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msVGlobalView As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msRecord As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msRFirst As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msRPrevious As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msRNext As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msRNew As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msRLast As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msRDelete As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents msLinea As System.Windows.Forms.ToolStripSeparator
    Protected WithEvents msRSearch As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msReport As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msRList As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msHelp As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msHSearch As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msHIndex As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msHContents As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msHAboutThis As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msTranslation As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents msTTranslation As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents pnlFill As System.Windows.Forms.Panel
    Protected WithEvents tbc As System.Windows.Forms.TabControl
    Protected WithEvents tbpDetail As System.Windows.Forms.TabPage
    Protected WithEvents tbpList As System.Windows.Forms.TabPage
    Public WithEvents dgvNPrin As System.Windows.Forms.DataGridView
    Public WithEvents bs As System.Windows.Forms.BindingSource
End Class
