<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrMain
    'Inherits System.Windows.Forms.Form
    Inherits LibTGest.FrFirst

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
        Me.msFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.msFExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.msCompany = New System.Windows.Forms.ToolStripMenuItem()
        Me.msCCompanyselection = New System.Windows.Forms.ToolStripMenuItem()
        Me.msCUserselection = New System.Windows.Forms.ToolStripMenuItem()
        Me.msCConfiguration = New System.Windows.Forms.ToolStripMenuItem()
        Me.msCSecuritycopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSale = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSBudget = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSServiceOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSDelivery = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSBill = New System.Windows.Forms.ToolStripMenuItem()
        Me.msBuy = New System.Windows.Forms.ToolStripMenuItem()
        Me.msBBudgetBuy = New System.Windows.Forms.ToolStripMenuItem()
        Me.msBOrderBuy = New System.Windows.Forms.ToolStripMenuItem()
        Me.msBDeliveryBuy = New System.Windows.Forms.ToolStripMenuItem()
        Me.msBBillbuy = New System.Windows.Forms.ToolStripMenuItem()
        Me.msDiary = New System.Windows.Forms.ToolStripMenuItem()
        Me.msDDiary = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSupplierandcustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSDistributor = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSActivity = New System.Windows.Forms.ToolStripMenuItem()
        Me.msAccounting = New System.Windows.Forms.ToolStripMenuItem()
        Me.msAAccountingPlan = New System.Windows.Forms.ToolStripMenuItem()
        Me.msASummaryofvat = New System.Windows.Forms.ToolStripMenuItem()
        Me.msStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSStore = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSStockmovements = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSSummaryofstock = New System.Windows.Forms.ToolStripMenuItem()
        Me.msArticles = New System.Windows.Forms.ToolStripMenuItem()
        Me.msAArticles = New System.Windows.Forms.ToolStripMenuItem()
        Me.msASubfamily = New System.Windows.Forms.ToolStripMenuItem()
        Me.msAFamily = New System.Windows.Forms.ToolStripMenuItem()
        Me.msPointofsale = New System.Windows.Forms.ToolStripMenuItem()
        Me.msPPsbudget = New System.Windows.Forms.ToolStripMenuItem()
        Me.msPPsOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.msPPsdelivery = New System.Windows.Forms.ToolStripMenuItem()
        Me.msPPsticket = New System.Windows.Forms.ToolStripMenuItem()
        Me.msPPsbill = New System.Windows.Forms.ToolStripMenuItem()
        Me.msPClosingcash = New System.Windows.Forms.ToolStripMenuItem()
        Me.msPHistoricaltickets = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlInf = New System.Windows.Forms.Panel()
        Me.prgBar = New System.Windows.Forms.ProgressBar()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.nb = New Guifreaks.NavigationBar.NaviBar(Me.components)
        Me.nb5SupAndCust = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.nb2Sale = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.nb1Company = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.nb3Buy = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.nb4Diary = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.nb6Accounting = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.nb7Stock = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.nb8Articles = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.nb9PointOfSale = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.nGSupAndCust = New Guifreaks.NavigationBar.NaviGroup(Me.components)
        Me.btt4Activity = New System.Windows.Forms.Button()
        Me.btt3Supplier = New System.Windows.Forms.Button()
        Me.btt2Distributor = New System.Windows.Forms.Button()
        Me.btt1Customer = New System.Windows.Forms.Button()
        Me.nGSale = New Guifreaks.NavigationBar.NaviGroup(Me.components)
        Me.btt5Bill = New System.Windows.Forms.Button()
        Me.btt4Delivery = New System.Windows.Forms.Button()
        Me.btt3Order = New System.Windows.Forms.Button()
        Me.btt2ServiceOrder = New System.Windows.Forms.Button()
        Me.btt1Budget = New System.Windows.Forms.Button()
        Me.nGCompany = New Guifreaks.NavigationBar.NaviGroup(Me.components)
        Me.btt4SecurityCopy = New System.Windows.Forms.Button()
        Me.btt3Configuration = New System.Windows.Forms.Button()
        Me.btt2UserSelection = New System.Windows.Forms.Button()
        Me.btt1CompanySelection = New System.Windows.Forms.Button()
        Me.nGBuy = New Guifreaks.NavigationBar.NaviGroup(Me.components)
        Me.btt4BillBuy = New System.Windows.Forms.Button()
        Me.btt3DeliveryBuy = New System.Windows.Forms.Button()
        Me.btt2OrderBuy = New System.Windows.Forms.Button()
        Me.btt1BudgetBuy = New System.Windows.Forms.Button()
        Me.nGDiary = New Guifreaks.NavigationBar.NaviGroup(Me.components)
        Me.btt1Diary = New System.Windows.Forms.Button()
        Me.nGAccounting = New Guifreaks.NavigationBar.NaviGroup(Me.components)
        Me.btt2SummaryOfVat = New System.Windows.Forms.Button()
        Me.btt1AccountingPlan = New System.Windows.Forms.Button()
        Me.nGStock = New Guifreaks.NavigationBar.NaviGroup(Me.components)
        Me.btt3SummaryOfStock = New System.Windows.Forms.Button()
        Me.btt2StockMovements = New System.Windows.Forms.Button()
        Me.btt1Store = New System.Windows.Forms.Button()
        Me.nGArticles = New Guifreaks.NavigationBar.NaviGroup(Me.components)
        Me.btt3Family = New System.Windows.Forms.Button()
        Me.btt2SubFamily = New System.Windows.Forms.Button()
        Me.btt1Articles = New System.Windows.Forms.Button()
        Me.nGPointOfSale = New Guifreaks.NavigationBar.NaviGroup(Me.components)
        Me.btt7HistoricalTickets = New System.Windows.Forms.Button()
        Me.btt6ClosingCash = New System.Windows.Forms.Button()
        Me.btt5PsBill = New System.Windows.Forms.Button()
        Me.btt4PsTicket = New System.Windows.Forms.Button()
        Me.btt3PsDelivery = New System.Windows.Forms.Button()
        Me.btt2PsOrder = New System.Windows.Forms.Button()
        Me.btt1PsBudget = New System.Windows.Forms.Button()
        Me.pnlSup = New System.Windows.Forms.Panel()
        Me.pnlSupLeft = New System.Windows.Forms.Panel()
        Me.ms = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem21 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem22 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem23 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem24 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem25 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem26 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem27 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem28 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem29 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem30 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem31 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem32 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem33 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem34 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem35 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem36 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem37 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem38 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem39 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem40 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem41 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem42 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem43 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem44 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlSupRight = New System.Windows.Forms.Panel()
        Me.lbCurrentUser = New System.Windows.Forms.Label()
        Me.lbCurrentCompany = New System.Windows.Forms.Label()
        Me.lbCompany = New System.Windows.Forms.Label()
        Me.lbUser = New System.Windows.Forms.Label()
        Me.pnlInf.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        CType(Me.nb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nb.SuspendLayout()
        Me.nb5SupAndCust.SuspendLayout()
        Me.nb2Sale.SuspendLayout()
        Me.nb1Company.SuspendLayout()
        Me.nb3Buy.SuspendLayout()
        Me.nb4Diary.SuspendLayout()
        Me.nb6Accounting.SuspendLayout()
        Me.nb7Stock.SuspendLayout()
        Me.nb8Articles.SuspendLayout()
        Me.nb9PointOfSale.SuspendLayout()
        CType(Me.nGSupAndCust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nGSupAndCust.SuspendLayout()
        CType(Me.nGSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nGSale.SuspendLayout()
        CType(Me.nGCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nGCompany.SuspendLayout()
        CType(Me.nGBuy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nGBuy.SuspendLayout()
        CType(Me.nGDiary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nGDiary.SuspendLayout()
        CType(Me.nGAccounting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nGAccounting.SuspendLayout()
        CType(Me.nGStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nGStock.SuspendLayout()
        CType(Me.nGArticles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nGArticles.SuspendLayout()
        CType(Me.nGPointOfSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nGPointOfSale.SuspendLayout()
        Me.pnlSup.SuspendLayout()
        Me.pnlSupLeft.SuspendLayout()
        Me.ms.SuspendLayout()
        Me.pnlSupRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'msFile
        '
        Me.msFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msFExit})
        Me.msFile.Name = "msFile"
        Me.msFile.Size = New System.Drawing.Size(37, 21)
        Me.msFile.Text = "File"
        '
        'msFExit
        '
        Me.msFExit.Name = "msFExit"
        Me.msFExit.Size = New System.Drawing.Size(92, 22)
        Me.msFExit.Text = "Exit"
        '
        'msCompany
        '
        Me.msCompany.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msCCompanyselection, Me.msCUserselection, Me.msCConfiguration, Me.msCSecuritycopy})
        Me.msCompany.Name = "msCompany"
        Me.msCompany.Size = New System.Drawing.Size(71, 21)
        Me.msCompany.Text = "Company"
        '
        'msCCompanyselection
        '
        Me.msCCompanyselection.Name = "msCCompanyselection"
        Me.msCCompanyselection.Size = New System.Drawing.Size(174, 22)
        Me.msCCompanyselection.Text = "CompanySelection"
        '
        'msCUserselection
        '
        Me.msCUserselection.Name = "msCUserselection"
        Me.msCUserselection.Size = New System.Drawing.Size(174, 22)
        Me.msCUserselection.Text = "UserSelection"
        '
        'msCConfiguration
        '
        Me.msCConfiguration.Name = "msCConfiguration"
        Me.msCConfiguration.Size = New System.Drawing.Size(174, 22)
        Me.msCConfiguration.Text = "Configuration"
        '
        'msCSecuritycopy
        '
        Me.msCSecuritycopy.Name = "msCSecuritycopy"
        Me.msCSecuritycopy.Size = New System.Drawing.Size(174, 22)
        Me.msCSecuritycopy.Text = "SecurityCopy"
        '
        'msSale
        '
        Me.msSale.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msSBudget, Me.msSServiceOrder, Me.msSOrder, Me.msSDelivery, Me.msSBill})
        Me.msSale.Name = "msSale"
        Me.msSale.Size = New System.Drawing.Size(40, 21)
        Me.msSale.Text = "Sale"
        '
        'msSBudget
        '
        Me.msSBudget.Name = "msSBudget"
        Me.msSBudget.Size = New System.Drawing.Size(144, 22)
        Me.msSBudget.Text = "Budget"
        '
        'msSServiceOrder
        '
        Me.msSServiceOrder.Name = "msSServiceOrder"
        Me.msSServiceOrder.Size = New System.Drawing.Size(144, 22)
        Me.msSServiceOrder.Text = "Service Order"
        '
        'msSOrder
        '
        Me.msSOrder.Name = "msSOrder"
        Me.msSOrder.Size = New System.Drawing.Size(144, 22)
        Me.msSOrder.Text = "Order"
        '
        'msSDelivery
        '
        Me.msSDelivery.Name = "msSDelivery"
        Me.msSDelivery.Size = New System.Drawing.Size(144, 22)
        Me.msSDelivery.Text = "Delivery"
        '
        'msSBill
        '
        Me.msSBill.Name = "msSBill"
        Me.msSBill.Size = New System.Drawing.Size(144, 22)
        Me.msSBill.Text = "Bill"
        '
        'msBuy
        '
        Me.msBuy.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msBBudgetBuy, Me.msBOrderBuy, Me.msBDeliveryBuy, Me.msBBillbuy})
        Me.msBuy.Name = "msBuy"
        Me.msBuy.Size = New System.Drawing.Size(39, 21)
        Me.msBuy.Text = "Buy"
        '
        'msBBudgetBuy
        '
        Me.msBBudgetBuy.Name = "msBBudgetBuy"
        Me.msBBudgetBuy.Size = New System.Drawing.Size(139, 22)
        Me.msBBudgetBuy.Text = "Budget Buy"
        '
        'msBOrderBuy
        '
        Me.msBOrderBuy.Name = "msBOrderBuy"
        Me.msBOrderBuy.Size = New System.Drawing.Size(139, 22)
        Me.msBOrderBuy.Text = "Order Buy"
        '
        'msBDeliveryBuy
        '
        Me.msBDeliveryBuy.Name = "msBDeliveryBuy"
        Me.msBDeliveryBuy.Size = New System.Drawing.Size(139, 22)
        Me.msBDeliveryBuy.Text = "Delivery Buy"
        '
        'msBBillbuy
        '
        Me.msBBillbuy.Name = "msBBillbuy"
        Me.msBBillbuy.Size = New System.Drawing.Size(139, 22)
        Me.msBBillbuy.Text = "Bill Buy"
        '
        'msDiary
        '
        Me.msDiary.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msDDiary})
        Me.msDiary.Name = "msDiary"
        Me.msDiary.Size = New System.Drawing.Size(46, 21)
        Me.msDiary.Text = "Diary"
        '
        'msDDiary
        '
        Me.msDDiary.Name = "msDDiary"
        Me.msDDiary.Size = New System.Drawing.Size(101, 22)
        Me.msDDiary.Text = "Diary"
        '
        'msSupplierandcustomer
        '
        Me.msSupplierandcustomer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msSCustomer, Me.msSDistributor, Me.msSSupplier, Me.msSActivity})
        Me.msSupplierandcustomer.Name = "msSupplierandcustomer"
        Me.msSupplierandcustomer.Size = New System.Drawing.Size(140, 21)
        Me.msSupplierandcustomer.Text = "Supplier and Customer"
        '
        'msSCustomer
        '
        Me.msSCustomer.Name = "msSCustomer"
        Me.msSCustomer.Size = New System.Drawing.Size(130, 22)
        Me.msSCustomer.Text = "Customer"
        '
        'msSDistributor
        '
        Me.msSDistributor.Name = "msSDistributor"
        Me.msSDistributor.Size = New System.Drawing.Size(130, 22)
        Me.msSDistributor.Text = "Distributor"
        '
        'msSSupplier
        '
        Me.msSSupplier.Name = "msSSupplier"
        Me.msSSupplier.Size = New System.Drawing.Size(130, 22)
        Me.msSSupplier.Text = "Supplier"
        '
        'msSActivity
        '
        Me.msSActivity.Name = "msSActivity"
        Me.msSActivity.Size = New System.Drawing.Size(130, 22)
        Me.msSActivity.Text = "Activity"
        '
        'msAccounting
        '
        Me.msAccounting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msAAccountingPlan, Me.msASummaryofvat})
        Me.msAccounting.Name = "msAccounting"
        Me.msAccounting.Size = New System.Drawing.Size(81, 21)
        Me.msAccounting.Text = "Accounting"
        '
        'msAAccountingPlan
        '
        Me.msAAccountingPlan.Name = "msAAccountingPlan"
        Me.msAAccountingPlan.Size = New System.Drawing.Size(164, 22)
        Me.msAAccountingPlan.Text = "Accounting Plan"
        '
        'msASummaryofvat
        '
        Me.msASummaryofvat.Name = "msASummaryofvat"
        Me.msASummaryofvat.Size = New System.Drawing.Size(164, 22)
        Me.msASummaryofvat.Text = "Summary of VAT"
        '
        'msStock
        '
        Me.msStock.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msSStore, Me.msSStockmovements, Me.msSSummaryofstock})
        Me.msStock.Name = "msStock"
        Me.msStock.Size = New System.Drawing.Size(48, 21)
        Me.msStock.Text = "Stock"
        '
        'msSStore
        '
        Me.msSStore.Name = "msSStore"
        Me.msSStore.Size = New System.Drawing.Size(171, 22)
        Me.msSStore.Text = "Store"
        '
        'msSStockmovements
        '
        Me.msSStockmovements.Name = "msSStockmovements"
        Me.msSStockmovements.Size = New System.Drawing.Size(171, 22)
        Me.msSStockmovements.Text = "Stock Movements"
        '
        'msSSummaryofstock
        '
        Me.msSSummaryofstock.Name = "msSSummaryofstock"
        Me.msSSummaryofstock.Size = New System.Drawing.Size(171, 22)
        Me.msSSummaryofstock.Text = "Summary of Stock"
        '
        'msArticles
        '
        Me.msArticles.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msAArticles, Me.msASubfamily, Me.msAFamily})
        Me.msArticles.Name = "msArticles"
        Me.msArticles.Size = New System.Drawing.Size(58, 21)
        Me.msArticles.Text = "Articles"
        '
        'msAArticles
        '
        Me.msAArticles.Name = "msAArticles"
        Me.msAArticles.Size = New System.Drawing.Size(129, 22)
        Me.msAArticles.Text = "Articles"
        '
        'msASubfamily
        '
        Me.msASubfamily.Name = "msASubfamily"
        Me.msASubfamily.Size = New System.Drawing.Size(129, 22)
        Me.msASubfamily.Text = "SubFamily"
        '
        'msAFamily
        '
        Me.msAFamily.Name = "msAFamily"
        Me.msAFamily.Size = New System.Drawing.Size(129, 22)
        Me.msAFamily.Text = "Family"
        '
        'msPointofsale
        '
        Me.msPointofsale.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msPPsbudget, Me.msPPsOrder, Me.msPPsdelivery, Me.msPPsticket, Me.msPPsbill, Me.msPClosingcash, Me.msPHistoricaltickets})
        Me.msPointofsale.Name = "msPointofsale"
        Me.msPointofsale.Size = New System.Drawing.Size(84, 21)
        Me.msPointofsale.Text = "Point of sale"
        '
        'msPPsbudget
        '
        Me.msPPsbudget.Name = "msPPsbudget"
        Me.msPPsbudget.Size = New System.Drawing.Size(161, 22)
        Me.msPPsbudget.Text = "PS Budget"
        '
        'msPPsOrder
        '
        Me.msPPsOrder.Name = "msPPsOrder"
        Me.msPPsOrder.Size = New System.Drawing.Size(161, 22)
        Me.msPPsOrder.Text = "PS Order"
        '
        'msPPsdelivery
        '
        Me.msPPsdelivery.Name = "msPPsdelivery"
        Me.msPPsdelivery.Size = New System.Drawing.Size(161, 22)
        Me.msPPsdelivery.Text = "PS Delivery"
        '
        'msPPsticket
        '
        Me.msPPsticket.Name = "msPPsticket"
        Me.msPPsticket.Size = New System.Drawing.Size(161, 22)
        Me.msPPsticket.Text = "PS Ticket"
        '
        'msPPsbill
        '
        Me.msPPsbill.Name = "msPPsbill"
        Me.msPPsbill.Size = New System.Drawing.Size(161, 22)
        Me.msPPsbill.Text = "PS Bill"
        '
        'msPClosingcash
        '
        Me.msPClosingcash.Name = "msPClosingcash"
        Me.msPClosingcash.Size = New System.Drawing.Size(161, 22)
        Me.msPClosingcash.Text = "Closing cash"
        '
        'msPHistoricaltickets
        '
        Me.msPHistoricaltickets.Name = "msPHistoricaltickets"
        Me.msPHistoricaltickets.Size = New System.Drawing.Size(161, 22)
        Me.msPHistoricaltickets.Text = "Historical tickets"
        '
        'pnlInf
        '
        Me.pnlInf.Controls.Add(Me.prgBar)
        Me.pnlInf.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlInf.Location = New System.Drawing.Point(0, 734)
        Me.pnlInf.Name = "pnlInf"
        Me.pnlInf.Size = New System.Drawing.Size(1264, 28)
        Me.pnlInf.TabIndex = 10
        '
        'prgBar
        '
        Me.prgBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.prgBar.Location = New System.Drawing.Point(0, 0)
        Me.prgBar.Name = "prgBar"
        Me.prgBar.Size = New System.Drawing.Size(1264, 28)
        Me.prgBar.TabIndex = 0
        '
        'pnlBody
        '
        Me.pnlBody.Controls.Add(Me.pnlLeft)
        Me.pnlBody.Controls.Add(Me.pnlRight)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 0)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(1264, 734)
        Me.pnlBody.TabIndex = 11
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.nb)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(229, 734)
        Me.pnlLeft.TabIndex = 4
        '
        'nb
        '
        Me.nb.ActiveBand = Me.nb5SupAndCust
        Me.nb.Controls.Add(Me.nb5SupAndCust)
        Me.nb.Controls.Add(Me.nb2Sale)
        Me.nb.Controls.Add(Me.nb1Company)
        Me.nb.Controls.Add(Me.nb3Buy)
        Me.nb.Controls.Add(Me.nb4Diary)
        Me.nb.Controls.Add(Me.nb6Accounting)
        Me.nb.Controls.Add(Me.nb7Stock)
        Me.nb.Controls.Add(Me.nb8Articles)
        Me.nb.Controls.Add(Me.nb9PointOfSale)
        Me.nb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nb.Location = New System.Drawing.Point(0, 0)
        Me.nb.Name = "nb"
        Me.nb.Size = New System.Drawing.Size(229, 734)
        Me.nb.TabIndex = 49
        Me.nb.Text = "nBSale"
        Me.nb.VisibleLargeButtons = 9
        '
        'nb5SupAndCust
        '
        '
        'nb5SupAndCust.ClientArea
        '
        Me.nb5SupAndCust.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.nb5SupAndCust.ClientArea.Name = "ClientArea"
        Me.nb5SupAndCust.ClientArea.Size = New System.Drawing.Size(227, 379)
        Me.nb5SupAndCust.ClientArea.TabIndex = 0
        Me.nb5SupAndCust.LargeImage = Global.TGest.My.Resources.Resources.XP_PPL01
        Me.nb5SupAndCust.Location = New System.Drawing.Point(1, 27)
        Me.nb5SupAndCust.Name = "nb5SupAndCust"
        Me.nb5SupAndCust.Size = New System.Drawing.Size(227, 379)
        Me.nb5SupAndCust.SmallImage = Global.TGest.My.Resources.Resources.XP_PPL01
        Me.nb5SupAndCust.TabIndex = 14
        Me.nb5SupAndCust.Text = "Supplier and Customer"
        '
        'nb2Sale
        '
        '
        'nb2Sale.ClientArea
        '
        Me.nb2Sale.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.nb2Sale.ClientArea.Name = "ClientArea"
        Me.nb2Sale.ClientArea.Size = New System.Drawing.Size(227, 379)
        Me.nb2Sale.ClientArea.TabIndex = 0
        Me.nb2Sale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nb2Sale.LargeImage = Global.TGest.My.Resources.Resources.Money
        Me.nb2Sale.Location = New System.Drawing.Point(1, 27)
        Me.nb2Sale.Name = "nb2Sale"
        Me.nb2Sale.Size = New System.Drawing.Size(227, 379)
        Me.nb2Sale.SmallImage = Global.TGest.My.Resources.Resources.Money
        Me.nb2Sale.TabIndex = 5
        Me.nb2Sale.Text = "Sale"
        '
        'nb1Company
        '
        '
        'nb1Company.ClientArea
        '
        Me.nb1Company.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.nb1Company.ClientArea.Name = "ClientArea"
        Me.nb1Company.ClientArea.Size = New System.Drawing.Size(227, 379)
        Me.nb1Company.ClientArea.TabIndex = 0
        Me.nb1Company.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nb1Company.LargeImage = Global.TGest.My.Resources.Resources.Work
        Me.nb1Company.Location = New System.Drawing.Point(1, 27)
        Me.nb1Company.Name = "nb1Company"
        Me.nb1Company.Size = New System.Drawing.Size(227, 379)
        Me.nb1Company.SmallImage = Global.TGest.My.Resources.Resources.Work
        Me.nb1Company.TabIndex = 3
        Me.nb1Company.Text = "Company"
        '
        'nb3Buy
        '
        '
        'nb3Buy.ClientArea
        '
        Me.nb3Buy.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.nb3Buy.ClientArea.Name = "ClientArea"
        Me.nb3Buy.ClientArea.Size = New System.Drawing.Size(227, 379)
        Me.nb3Buy.ClientArea.TabIndex = 0
        Me.nb3Buy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nb3Buy.LargeImage = Global.TGest.My.Resources.Resources.Car
        Me.nb3Buy.Location = New System.Drawing.Point(1, 27)
        Me.nb3Buy.Name = "nb3Buy"
        Me.nb3Buy.Size = New System.Drawing.Size(227, 379)
        Me.nb3Buy.SmallImage = Global.TGest.My.Resources.Resources.Car
        Me.nb3Buy.TabIndex = 7
        Me.nb3Buy.Text = "Buy"
        '
        'nb4Diary
        '
        '
        'nb4Diary.ClientArea
        '
        Me.nb4Diary.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.nb4Diary.ClientArea.Name = "ClientArea"
        Me.nb4Diary.ClientArea.Size = New System.Drawing.Size(227, 379)
        Me.nb4Diary.ClientArea.TabIndex = 0
        Me.nb4Diary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nb4Diary.LargeImage = Global.TGest.My.Resources.Resources.vcard
        Me.nb4Diary.Location = New System.Drawing.Point(1, 27)
        Me.nb4Diary.Name = "nb4Diary"
        Me.nb4Diary.Size = New System.Drawing.Size(227, 379)
        Me.nb4Diary.SmallImage = Global.TGest.My.Resources.Resources.vcard
        Me.nb4Diary.TabIndex = 9
        Me.nb4Diary.Text = "Diary"
        '
        'nb6Accounting
        '
        '
        'nb6Accounting.ClientArea
        '
        Me.nb6Accounting.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.nb6Accounting.ClientArea.Name = "ClientArea"
        Me.nb6Accounting.ClientArea.Size = New System.Drawing.Size(227, 379)
        Me.nb6Accounting.ClientArea.TabIndex = 0
        Me.nb6Accounting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nb6Accounting.LargeImage = Global.TGest.My.Resources.Resources.Pen
        Me.nb6Accounting.Location = New System.Drawing.Point(1, 27)
        Me.nb6Accounting.Name = "nb6Accounting"
        Me.nb6Accounting.Size = New System.Drawing.Size(227, 379)
        Me.nb6Accounting.SmallImage = Global.TGest.My.Resources.Resources.Pen
        Me.nb6Accounting.TabIndex = 19
        Me.nb6Accounting.Text = "Accounting"
        '
        'nb7Stock
        '
        '
        'nb7Stock.ClientArea
        '
        Me.nb7Stock.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.nb7Stock.ClientArea.Name = "ClientArea"
        Me.nb7Stock.ClientArea.Size = New System.Drawing.Size(227, 379)
        Me.nb7Stock.ClientArea.TabIndex = 0
        Me.nb7Stock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nb7Stock.LargeImage = Global.TGest.My.Resources.Resources.Stockage
        Me.nb7Stock.Location = New System.Drawing.Point(1, 27)
        Me.nb7Stock.Name = "nb7Stock"
        Me.nb7Stock.Size = New System.Drawing.Size(227, 379)
        Me.nb7Stock.SmallImage = Global.TGest.My.Resources.Resources.Stockage
        Me.nb7Stock.TabIndex = 25
        Me.nb7Stock.Text = "Stock"
        '
        'nb8Articles
        '
        '
        'nb8Articles.ClientArea
        '
        Me.nb8Articles.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.nb8Articles.ClientArea.Name = "ClientArea"
        Me.nb8Articles.ClientArea.Size = New System.Drawing.Size(227, 379)
        Me.nb8Articles.ClientArea.TabIndex = 0
        Me.nb8Articles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nb8Articles.Location = New System.Drawing.Point(1, 27)
        Me.nb8Articles.Name = "nb8Articles"
        Me.nb8Articles.Size = New System.Drawing.Size(227, 379)
        Me.nb8Articles.TabIndex = 34
        Me.nb8Articles.Text = "Articles"
        '
        'nb9PointOfSale
        '
        '
        'nb9PointOfSale.ClientArea
        '
        Me.nb9PointOfSale.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.nb9PointOfSale.ClientArea.Name = "ClientArea"
        Me.nb9PointOfSale.ClientArea.Size = New System.Drawing.Size(227, 379)
        Me.nb9PointOfSale.ClientArea.TabIndex = 0
        Me.nb9PointOfSale.Location = New System.Drawing.Point(1, 27)
        Me.nb9PointOfSale.Name = "nb9PointOfSale"
        Me.nb9PointOfSale.Size = New System.Drawing.Size(227, 379)
        Me.nb9PointOfSale.TabIndex = 45
        Me.nb9PointOfSale.Text = "Point of sale"
        '
        'pnlRight
        '
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(0, 0)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(1264, 734)
        Me.pnlRight.TabIndex = 2
        '
        'nGSupAndCust
        '
        Me.nGSupAndCust.Caption = Nothing
        Me.nGSupAndCust.Controls.Add(Me.btt4Activity)
        Me.nGSupAndCust.Controls.Add(Me.btt3Supplier)
        Me.nGSupAndCust.Controls.Add(Me.btt2Distributor)
        Me.nGSupAndCust.Controls.Add(Me.btt1Customer)
        Me.nGSupAndCust.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nGSupAndCust.Expanded = False
        Me.nGSupAndCust.HeaderContextMenuStrip = Nothing
        Me.nGSupAndCust.Location = New System.Drawing.Point(0, 0)
        Me.nGSupAndCust.Name = "nGSupAndCust"
        Me.nGSupAndCust.Padding = New System.Windows.Forms.Padding(1, 22, 1, 1)
        Me.nGSupAndCust.Size = New System.Drawing.Size(227, 354)
        Me.nGSupAndCust.TabIndex = 48
        Me.nGSupAndCust.Text = "nGSupAndCust"
        '
        'btt4Activity
        '
        Me.btt4Activity.BackColor = System.Drawing.SystemColors.Window
        Me.btt4Activity.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt4Activity.FlatAppearance.BorderSize = 2
        Me.btt4Activity.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt4Activity.Location = New System.Drawing.Point(1, 109)
        Me.btt4Activity.Name = "btt4Activity"
        Me.btt4Activity.Size = New System.Drawing.Size(225, 29)
        Me.btt4Activity.TabIndex = 25
        Me.btt4Activity.Text = "Activity"
        Me.btt4Activity.UseVisualStyleBackColor = False
        '
        'btt3Supplier
        '
        Me.btt3Supplier.BackColor = System.Drawing.SystemColors.Window
        Me.btt3Supplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt3Supplier.FlatAppearance.BorderSize = 2
        Me.btt3Supplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt3Supplier.Location = New System.Drawing.Point(1, 80)
        Me.btt3Supplier.Name = "btt3Supplier"
        Me.btt3Supplier.Size = New System.Drawing.Size(225, 29)
        Me.btt3Supplier.TabIndex = 24
        Me.btt3Supplier.Text = "Supplier"
        Me.btt3Supplier.UseVisualStyleBackColor = False
        '
        'btt2Distributor
        '
        Me.btt2Distributor.BackColor = System.Drawing.SystemColors.Window
        Me.btt2Distributor.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt2Distributor.FlatAppearance.BorderSize = 2
        Me.btt2Distributor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt2Distributor.Location = New System.Drawing.Point(1, 51)
        Me.btt2Distributor.Name = "btt2Distributor"
        Me.btt2Distributor.Size = New System.Drawing.Size(225, 29)
        Me.btt2Distributor.TabIndex = 23
        Me.btt2Distributor.Text = "Distributor"
        Me.btt2Distributor.UseVisualStyleBackColor = False
        '
        'btt1Customer
        '
        Me.btt1Customer.BackColor = System.Drawing.SystemColors.Window
        Me.btt1Customer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt1Customer.FlatAppearance.BorderSize = 2
        Me.btt1Customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt1Customer.Location = New System.Drawing.Point(1, 22)
        Me.btt1Customer.Name = "btt1Customer"
        Me.btt1Customer.Size = New System.Drawing.Size(225, 29)
        Me.btt1Customer.TabIndex = 22
        Me.btt1Customer.Text = "Customer"
        Me.btt1Customer.UseVisualStyleBackColor = False
        '
        'nGSale
        '
        Me.nGSale.Caption = Nothing
        Me.nGSale.Controls.Add(Me.btt5Bill)
        Me.nGSale.Controls.Add(Me.btt4Delivery)
        Me.nGSale.Controls.Add(Me.btt3Order)
        Me.nGSale.Controls.Add(Me.btt2ServiceOrder)
        Me.nGSale.Controls.Add(Me.btt1Budget)
        Me.nGSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nGSale.HeaderContextMenuStrip = Nothing
        Me.nGSale.Location = New System.Drawing.Point(0, 0)
        Me.nGSale.Name = "nGSale"
        Me.nGSale.Padding = New System.Windows.Forms.Padding(1, 22, 1, 1)
        Me.nGSale.Size = New System.Drawing.Size(227, 354)
        Me.nGSale.TabIndex = 0
        Me.nGSale.Text = "naviGroup1"
        '
        'btt5Bill
        '
        Me.btt5Bill.BackColor = System.Drawing.SystemColors.Window
        Me.btt5Bill.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt5Bill.FlatAppearance.BorderSize = 2
        Me.btt5Bill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt5Bill.Location = New System.Drawing.Point(1, 138)
        Me.btt5Bill.Name = "btt5Bill"
        Me.btt5Bill.Size = New System.Drawing.Size(225, 29)
        Me.btt5Bill.TabIndex = 26
        Me.btt5Bill.Text = "Bill"
        Me.btt5Bill.UseVisualStyleBackColor = False
        '
        'btt4Delivery
        '
        Me.btt4Delivery.BackColor = System.Drawing.SystemColors.Window
        Me.btt4Delivery.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt4Delivery.FlatAppearance.BorderSize = 2
        Me.btt4Delivery.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt4Delivery.Location = New System.Drawing.Point(1, 109)
        Me.btt4Delivery.Name = "btt4Delivery"
        Me.btt4Delivery.Size = New System.Drawing.Size(225, 29)
        Me.btt4Delivery.TabIndex = 25
        Me.btt4Delivery.Text = "Delivery"
        Me.btt4Delivery.UseVisualStyleBackColor = False
        '
        'btt3Order
        '
        Me.btt3Order.BackColor = System.Drawing.SystemColors.Window
        Me.btt3Order.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt3Order.FlatAppearance.BorderSize = 2
        Me.btt3Order.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt3Order.Location = New System.Drawing.Point(1, 80)
        Me.btt3Order.Name = "btt3Order"
        Me.btt3Order.Size = New System.Drawing.Size(225, 29)
        Me.btt3Order.TabIndex = 24
        Me.btt3Order.Text = "Order"
        Me.btt3Order.UseVisualStyleBackColor = False
        '
        'btt2ServiceOrder
        '
        Me.btt2ServiceOrder.BackColor = System.Drawing.SystemColors.Window
        Me.btt2ServiceOrder.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt2ServiceOrder.FlatAppearance.BorderSize = 2
        Me.btt2ServiceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt2ServiceOrder.Location = New System.Drawing.Point(1, 51)
        Me.btt2ServiceOrder.Name = "btt2ServiceOrder"
        Me.btt2ServiceOrder.Size = New System.Drawing.Size(225, 29)
        Me.btt2ServiceOrder.TabIndex = 23
        Me.btt2ServiceOrder.Text = "Service Order"
        Me.btt2ServiceOrder.UseVisualStyleBackColor = False
        '
        'btt1Budget
        '
        Me.btt1Budget.BackColor = System.Drawing.SystemColors.Window
        Me.btt1Budget.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt1Budget.FlatAppearance.BorderSize = 2
        Me.btt1Budget.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt1Budget.Location = New System.Drawing.Point(1, 22)
        Me.btt1Budget.Name = "btt1Budget"
        Me.btt1Budget.Size = New System.Drawing.Size(225, 29)
        Me.btt1Budget.TabIndex = 22
        Me.btt1Budget.Text = "Budget"
        Me.btt1Budget.UseVisualStyleBackColor = False
        '
        'nGCompany
        '
        Me.nGCompany.Caption = Nothing
        Me.nGCompany.Controls.Add(Me.btt4SecurityCopy)
        Me.nGCompany.Controls.Add(Me.btt3Configuration)
        Me.nGCompany.Controls.Add(Me.btt2UserSelection)
        Me.nGCompany.Controls.Add(Me.btt1CompanySelection)
        Me.nGCompany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nGCompany.Expanded = False
        Me.nGCompany.ExpandedHeight = 138
        Me.nGCompany.HeaderContextMenuStrip = Nothing
        Me.nGCompany.Location = New System.Drawing.Point(0, 0)
        Me.nGCompany.Name = "nGCompany"
        Me.nGCompany.Padding = New System.Windows.Forms.Padding(1, 22, 1, 1)
        Me.nGCompany.Size = New System.Drawing.Size(227, 354)
        Me.nGCompany.TabIndex = 0
        Me.nGCompany.Text = "nGCompany"
        '
        'btt4SecurityCopy
        '
        Me.btt4SecurityCopy.BackColor = System.Drawing.SystemColors.Window
        Me.btt4SecurityCopy.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt4SecurityCopy.FlatAppearance.BorderSize = 2
        Me.btt4SecurityCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt4SecurityCopy.Location = New System.Drawing.Point(1, 109)
        Me.btt4SecurityCopy.Name = "btt4SecurityCopy"
        Me.btt4SecurityCopy.Size = New System.Drawing.Size(225, 29)
        Me.btt4SecurityCopy.TabIndex = 24
        Me.btt4SecurityCopy.Text = "SecurityCopy"
        Me.btt4SecurityCopy.UseVisualStyleBackColor = False
        '
        'btt3Configuration
        '
        Me.btt3Configuration.BackColor = System.Drawing.SystemColors.Window
        Me.btt3Configuration.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt3Configuration.FlatAppearance.BorderSize = 2
        Me.btt3Configuration.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt3Configuration.Location = New System.Drawing.Point(1, 80)
        Me.btt3Configuration.Name = "btt3Configuration"
        Me.btt3Configuration.Size = New System.Drawing.Size(225, 29)
        Me.btt3Configuration.TabIndex = 23
        Me.btt3Configuration.Text = "Configuration"
        Me.btt3Configuration.UseVisualStyleBackColor = False
        '
        'btt2UserSelection
        '
        Me.btt2UserSelection.BackColor = System.Drawing.SystemColors.Window
        Me.btt2UserSelection.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt2UserSelection.FlatAppearance.BorderSize = 2
        Me.btt2UserSelection.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt2UserSelection.Location = New System.Drawing.Point(1, 51)
        Me.btt2UserSelection.Name = "btt2UserSelection"
        Me.btt2UserSelection.Size = New System.Drawing.Size(225, 29)
        Me.btt2UserSelection.TabIndex = 22
        Me.btt2UserSelection.Text = "UserSelection"
        Me.btt2UserSelection.UseVisualStyleBackColor = False
        '
        'btt1CompanySelection
        '
        Me.btt1CompanySelection.BackColor = System.Drawing.SystemColors.Window
        Me.btt1CompanySelection.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt1CompanySelection.FlatAppearance.BorderSize = 2
        Me.btt1CompanySelection.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt1CompanySelection.Location = New System.Drawing.Point(1, 22)
        Me.btt1CompanySelection.Name = "btt1CompanySelection"
        Me.btt1CompanySelection.Size = New System.Drawing.Size(225, 29)
        Me.btt1CompanySelection.TabIndex = 21
        Me.btt1CompanySelection.Text = "CompanySelection"
        Me.btt1CompanySelection.UseVisualStyleBackColor = False
        '
        'nGBuy
        '
        Me.nGBuy.Caption = Nothing
        Me.nGBuy.Controls.Add(Me.btt4BillBuy)
        Me.nGBuy.Controls.Add(Me.btt3DeliveryBuy)
        Me.nGBuy.Controls.Add(Me.btt2OrderBuy)
        Me.nGBuy.Controls.Add(Me.btt1BudgetBuy)
        Me.nGBuy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nGBuy.Expanded = False
        Me.nGBuy.HeaderContextMenuStrip = Nothing
        Me.nGBuy.Location = New System.Drawing.Point(0, 0)
        Me.nGBuy.Name = "nGBuy"
        Me.nGBuy.Padding = New System.Windows.Forms.Padding(1, 22, 1, 1)
        Me.nGBuy.Size = New System.Drawing.Size(227, 354)
        Me.nGBuy.TabIndex = 49
        Me.nGBuy.Text = "nGBuy"
        '
        'btt4BillBuy
        '
        Me.btt4BillBuy.BackColor = System.Drawing.SystemColors.Window
        Me.btt4BillBuy.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt4BillBuy.FlatAppearance.BorderSize = 2
        Me.btt4BillBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt4BillBuy.Location = New System.Drawing.Point(1, 109)
        Me.btt4BillBuy.Name = "btt4BillBuy"
        Me.btt4BillBuy.Size = New System.Drawing.Size(225, 29)
        Me.btt4BillBuy.TabIndex = 25
        Me.btt4BillBuy.Text = "Bill Buy"
        Me.btt4BillBuy.UseVisualStyleBackColor = False
        '
        'btt3DeliveryBuy
        '
        Me.btt3DeliveryBuy.BackColor = System.Drawing.SystemColors.Window
        Me.btt3DeliveryBuy.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt3DeliveryBuy.FlatAppearance.BorderSize = 2
        Me.btt3DeliveryBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt3DeliveryBuy.Location = New System.Drawing.Point(1, 80)
        Me.btt3DeliveryBuy.Name = "btt3DeliveryBuy"
        Me.btt3DeliveryBuy.Size = New System.Drawing.Size(225, 29)
        Me.btt3DeliveryBuy.TabIndex = 24
        Me.btt3DeliveryBuy.Text = "Delivery Buy"
        Me.btt3DeliveryBuy.UseVisualStyleBackColor = False
        '
        'btt2OrderBuy
        '
        Me.btt2OrderBuy.BackColor = System.Drawing.SystemColors.Window
        Me.btt2OrderBuy.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt2OrderBuy.FlatAppearance.BorderSize = 2
        Me.btt2OrderBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt2OrderBuy.Location = New System.Drawing.Point(1, 51)
        Me.btt2OrderBuy.Name = "btt2OrderBuy"
        Me.btt2OrderBuy.Size = New System.Drawing.Size(225, 29)
        Me.btt2OrderBuy.TabIndex = 23
        Me.btt2OrderBuy.Text = "Order Buy"
        Me.btt2OrderBuy.UseVisualStyleBackColor = False
        '
        'btt1BudgetBuy
        '
        Me.btt1BudgetBuy.BackColor = System.Drawing.SystemColors.Window
        Me.btt1BudgetBuy.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt1BudgetBuy.FlatAppearance.BorderSize = 2
        Me.btt1BudgetBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt1BudgetBuy.Location = New System.Drawing.Point(1, 22)
        Me.btt1BudgetBuy.Name = "btt1BudgetBuy"
        Me.btt1BudgetBuy.Size = New System.Drawing.Size(225, 29)
        Me.btt1BudgetBuy.TabIndex = 22
        Me.btt1BudgetBuy.Text = "Budget Buy"
        Me.btt1BudgetBuy.UseVisualStyleBackColor = False
        '
        'nGDiary
        '
        Me.nGDiary.Caption = Nothing
        Me.nGDiary.Controls.Add(Me.btt1Diary)
        Me.nGDiary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nGDiary.Expanded = False
        Me.nGDiary.HeaderContextMenuStrip = Nothing
        Me.nGDiary.Location = New System.Drawing.Point(0, 0)
        Me.nGDiary.Name = "nGDiary"
        Me.nGDiary.Padding = New System.Windows.Forms.Padding(1, 22, 1, 1)
        Me.nGDiary.Size = New System.Drawing.Size(227, 354)
        Me.nGDiary.TabIndex = 0
        Me.nGDiary.Text = "nGDiary"
        '
        'btt1Diary
        '
        Me.btt1Diary.BackColor = System.Drawing.SystemColors.Window
        Me.btt1Diary.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt1Diary.FlatAppearance.BorderSize = 2
        Me.btt1Diary.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt1Diary.Location = New System.Drawing.Point(1, 22)
        Me.btt1Diary.Name = "btt1Diary"
        Me.btt1Diary.Size = New System.Drawing.Size(225, 29)
        Me.btt1Diary.TabIndex = 22
        Me.btt1Diary.Text = "Diary"
        Me.btt1Diary.UseVisualStyleBackColor = False
        '
        'nGAccounting
        '
        Me.nGAccounting.Caption = Nothing
        Me.nGAccounting.Controls.Add(Me.btt2SummaryOfVat)
        Me.nGAccounting.Controls.Add(Me.btt1AccountingPlan)
        Me.nGAccounting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nGAccounting.HeaderContextMenuStrip = Nothing
        Me.nGAccounting.Location = New System.Drawing.Point(0, 0)
        Me.nGAccounting.Name = "nGAccounting"
        Me.nGAccounting.Padding = New System.Windows.Forms.Padding(1, 22, 1, 1)
        Me.nGAccounting.Size = New System.Drawing.Size(227, 354)
        Me.nGAccounting.TabIndex = 3
        Me.nGAccounting.Text = "naviGroup1"
        '
        'btt2SummaryOfVat
        '
        Me.btt2SummaryOfVat.BackColor = System.Drawing.SystemColors.Window
        Me.btt2SummaryOfVat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt2SummaryOfVat.FlatAppearance.BorderSize = 2
        Me.btt2SummaryOfVat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt2SummaryOfVat.Location = New System.Drawing.Point(1, 51)
        Me.btt2SummaryOfVat.Name = "btt2SummaryOfVat"
        Me.btt2SummaryOfVat.Size = New System.Drawing.Size(225, 29)
        Me.btt2SummaryOfVat.TabIndex = 23
        Me.btt2SummaryOfVat.Text = "Summary of VAT"
        Me.btt2SummaryOfVat.UseVisualStyleBackColor = False
        '
        'btt1AccountingPlan
        '
        Me.btt1AccountingPlan.BackColor = System.Drawing.SystemColors.Window
        Me.btt1AccountingPlan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt1AccountingPlan.FlatAppearance.BorderSize = 2
        Me.btt1AccountingPlan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt1AccountingPlan.Location = New System.Drawing.Point(1, 22)
        Me.btt1AccountingPlan.Name = "btt1AccountingPlan"
        Me.btt1AccountingPlan.Size = New System.Drawing.Size(225, 29)
        Me.btt1AccountingPlan.TabIndex = 22
        Me.btt1AccountingPlan.Text = "Accounting Plan"
        Me.btt1AccountingPlan.UseVisualStyleBackColor = False
        '
        'nGStock
        '
        Me.nGStock.Caption = Nothing
        Me.nGStock.Controls.Add(Me.btt3SummaryOfStock)
        Me.nGStock.Controls.Add(Me.btt2StockMovements)
        Me.nGStock.Controls.Add(Me.btt1Store)
        Me.nGStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nGStock.HeaderContextMenuStrip = Nothing
        Me.nGStock.Location = New System.Drawing.Point(0, 0)
        Me.nGStock.Name = "nGStock"
        Me.nGStock.Padding = New System.Windows.Forms.Padding(1, 22, 1, 1)
        Me.nGStock.Size = New System.Drawing.Size(227, 354)
        Me.nGStock.TabIndex = 0
        Me.nGStock.Text = "nGStock"
        '
        'btt3SummaryOfStock
        '
        Me.btt3SummaryOfStock.BackColor = System.Drawing.SystemColors.Window
        Me.btt3SummaryOfStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt3SummaryOfStock.FlatAppearance.BorderSize = 2
        Me.btt3SummaryOfStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt3SummaryOfStock.Location = New System.Drawing.Point(1, 80)
        Me.btt3SummaryOfStock.Name = "btt3SummaryOfStock"
        Me.btt3SummaryOfStock.Size = New System.Drawing.Size(225, 29)
        Me.btt3SummaryOfStock.TabIndex = 24
        Me.btt3SummaryOfStock.Text = "Summary of Stock"
        Me.btt3SummaryOfStock.UseVisualStyleBackColor = False
        '
        'btt2StockMovements
        '
        Me.btt2StockMovements.BackColor = System.Drawing.SystemColors.Window
        Me.btt2StockMovements.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt2StockMovements.FlatAppearance.BorderSize = 2
        Me.btt2StockMovements.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt2StockMovements.Location = New System.Drawing.Point(1, 51)
        Me.btt2StockMovements.Name = "btt2StockMovements"
        Me.btt2StockMovements.Size = New System.Drawing.Size(225, 29)
        Me.btt2StockMovements.TabIndex = 23
        Me.btt2StockMovements.Text = "Stock Movements"
        Me.btt2StockMovements.UseVisualStyleBackColor = False
        '
        'btt1Store
        '
        Me.btt1Store.BackColor = System.Drawing.SystemColors.Window
        Me.btt1Store.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt1Store.FlatAppearance.BorderSize = 2
        Me.btt1Store.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt1Store.Location = New System.Drawing.Point(1, 22)
        Me.btt1Store.Name = "btt1Store"
        Me.btt1Store.Size = New System.Drawing.Size(225, 29)
        Me.btt1Store.TabIndex = 22
        Me.btt1Store.Text = "Store"
        Me.btt1Store.UseVisualStyleBackColor = False
        '
        'nGArticles
        '
        Me.nGArticles.Caption = Nothing
        Me.nGArticles.Controls.Add(Me.btt3Family)
        Me.nGArticles.Controls.Add(Me.btt2SubFamily)
        Me.nGArticles.Controls.Add(Me.btt1Articles)
        Me.nGArticles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nGArticles.ExpandedHeight = 315
        Me.nGArticles.HeaderContextMenuStrip = Nothing
        Me.nGArticles.Location = New System.Drawing.Point(0, 0)
        Me.nGArticles.Name = "nGArticles"
        Me.nGArticles.Padding = New System.Windows.Forms.Padding(1, 22, 1, 1)
        Me.nGArticles.Size = New System.Drawing.Size(227, 354)
        Me.nGArticles.TabIndex = 51
        Me.nGArticles.Text = "Articles"
        '
        'btt3Family
        '
        Me.btt3Family.BackColor = System.Drawing.SystemColors.Window
        Me.btt3Family.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt3Family.FlatAppearance.BorderSize = 2
        Me.btt3Family.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt3Family.Location = New System.Drawing.Point(1, 80)
        Me.btt3Family.Name = "btt3Family"
        Me.btt3Family.Size = New System.Drawing.Size(225, 29)
        Me.btt3Family.TabIndex = 25
        Me.btt3Family.Text = "Family"
        Me.btt3Family.UseVisualStyleBackColor = False
        '
        'btt2SubFamily
        '
        Me.btt2SubFamily.BackColor = System.Drawing.SystemColors.Window
        Me.btt2SubFamily.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt2SubFamily.FlatAppearance.BorderSize = 2
        Me.btt2SubFamily.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt2SubFamily.Location = New System.Drawing.Point(1, 51)
        Me.btt2SubFamily.Name = "btt2SubFamily"
        Me.btt2SubFamily.Size = New System.Drawing.Size(225, 29)
        Me.btt2SubFamily.TabIndex = 24
        Me.btt2SubFamily.Text = "SubFamily"
        Me.btt2SubFamily.UseVisualStyleBackColor = False
        '
        'btt1Articles
        '
        Me.btt1Articles.BackColor = System.Drawing.SystemColors.Window
        Me.btt1Articles.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt1Articles.FlatAppearance.BorderSize = 2
        Me.btt1Articles.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt1Articles.Location = New System.Drawing.Point(1, 22)
        Me.btt1Articles.Name = "btt1Articles"
        Me.btt1Articles.Size = New System.Drawing.Size(225, 29)
        Me.btt1Articles.TabIndex = 23
        Me.btt1Articles.Text = "Articles"
        Me.btt1Articles.UseVisualStyleBackColor = False
        '
        'nGPointOfSale
        '
        Me.nGPointOfSale.Caption = Nothing
        Me.nGPointOfSale.Controls.Add(Me.btt7HistoricalTickets)
        Me.nGPointOfSale.Controls.Add(Me.btt6ClosingCash)
        Me.nGPointOfSale.Controls.Add(Me.btt5PsBill)
        Me.nGPointOfSale.Controls.Add(Me.btt4PsTicket)
        Me.nGPointOfSale.Controls.Add(Me.btt3PsDelivery)
        Me.nGPointOfSale.Controls.Add(Me.btt2PsOrder)
        Me.nGPointOfSale.Controls.Add(Me.btt1PsBudget)
        Me.nGPointOfSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nGPointOfSale.Expanded = False
        Me.nGPointOfSale.HeaderContextMenuStrip = Nothing
        Me.nGPointOfSale.Location = New System.Drawing.Point(0, 0)
        Me.nGPointOfSale.Name = "nGPointOfSale"
        Me.nGPointOfSale.Padding = New System.Windows.Forms.Padding(1, 22, 1, 1)
        Me.nGPointOfSale.Size = New System.Drawing.Size(227, 354)
        Me.nGPointOfSale.TabIndex = 47
        Me.nGPointOfSale.Text = "nGPointOfSale"
        '
        'btt7HistoricalTickets
        '
        Me.btt7HistoricalTickets.BackColor = System.Drawing.SystemColors.Window
        Me.btt7HistoricalTickets.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt7HistoricalTickets.FlatAppearance.BorderSize = 2
        Me.btt7HistoricalTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt7HistoricalTickets.Location = New System.Drawing.Point(1, 196)
        Me.btt7HistoricalTickets.Name = "btt7HistoricalTickets"
        Me.btt7HistoricalTickets.Size = New System.Drawing.Size(225, 29)
        Me.btt7HistoricalTickets.TabIndex = 32
        Me.btt7HistoricalTickets.Text = "Historical tickets"
        Me.btt7HistoricalTickets.UseVisualStyleBackColor = False
        '
        'btt6ClosingCash
        '
        Me.btt6ClosingCash.BackColor = System.Drawing.SystemColors.Window
        Me.btt6ClosingCash.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt6ClosingCash.FlatAppearance.BorderSize = 2
        Me.btt6ClosingCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt6ClosingCash.Location = New System.Drawing.Point(1, 167)
        Me.btt6ClosingCash.Name = "btt6ClosingCash"
        Me.btt6ClosingCash.Size = New System.Drawing.Size(225, 29)
        Me.btt6ClosingCash.TabIndex = 31
        Me.btt6ClosingCash.Text = "Closing cash"
        Me.btt6ClosingCash.UseVisualStyleBackColor = False
        '
        'btt5PsBill
        '
        Me.btt5PsBill.BackColor = System.Drawing.SystemColors.Window
        Me.btt5PsBill.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt5PsBill.FlatAppearance.BorderSize = 2
        Me.btt5PsBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt5PsBill.Location = New System.Drawing.Point(1, 138)
        Me.btt5PsBill.Name = "btt5PsBill"
        Me.btt5PsBill.Size = New System.Drawing.Size(225, 29)
        Me.btt5PsBill.TabIndex = 30
        Me.btt5PsBill.Text = "PS Bill"
        Me.btt5PsBill.UseVisualStyleBackColor = False
        '
        'btt4PsTicket
        '
        Me.btt4PsTicket.BackColor = System.Drawing.SystemColors.Window
        Me.btt4PsTicket.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt4PsTicket.FlatAppearance.BorderSize = 2
        Me.btt4PsTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt4PsTicket.Location = New System.Drawing.Point(1, 109)
        Me.btt4PsTicket.Name = "btt4PsTicket"
        Me.btt4PsTicket.Size = New System.Drawing.Size(225, 29)
        Me.btt4PsTicket.TabIndex = 29
        Me.btt4PsTicket.Text = "PS Ticket"
        Me.btt4PsTicket.UseVisualStyleBackColor = False
        '
        'btt3PsDelivery
        '
        Me.btt3PsDelivery.BackColor = System.Drawing.SystemColors.Window
        Me.btt3PsDelivery.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt3PsDelivery.FlatAppearance.BorderSize = 2
        Me.btt3PsDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt3PsDelivery.Location = New System.Drawing.Point(1, 80)
        Me.btt3PsDelivery.Name = "btt3PsDelivery"
        Me.btt3PsDelivery.Size = New System.Drawing.Size(225, 29)
        Me.btt3PsDelivery.TabIndex = 28
        Me.btt3PsDelivery.Text = "PS Delivery"
        Me.btt3PsDelivery.UseVisualStyleBackColor = False
        '
        'btt2PsOrder
        '
        Me.btt2PsOrder.BackColor = System.Drawing.SystemColors.Window
        Me.btt2PsOrder.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt2PsOrder.FlatAppearance.BorderSize = 2
        Me.btt2PsOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt2PsOrder.Location = New System.Drawing.Point(1, 51)
        Me.btt2PsOrder.Name = "btt2PsOrder"
        Me.btt2PsOrder.Size = New System.Drawing.Size(225, 29)
        Me.btt2PsOrder.TabIndex = 27
        Me.btt2PsOrder.Text = "PS Order"
        Me.btt2PsOrder.UseVisualStyleBackColor = False
        '
        'btt1PsBudget
        '
        Me.btt1PsBudget.BackColor = System.Drawing.SystemColors.Window
        Me.btt1PsBudget.Dock = System.Windows.Forms.DockStyle.Top
        Me.btt1PsBudget.FlatAppearance.BorderSize = 2
        Me.btt1PsBudget.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btt1PsBudget.Location = New System.Drawing.Point(1, 22)
        Me.btt1PsBudget.Name = "btt1PsBudget"
        Me.btt1PsBudget.Size = New System.Drawing.Size(225, 29)
        Me.btt1PsBudget.TabIndex = 26
        Me.btt1PsBudget.Text = "PS Budget"
        Me.btt1PsBudget.UseVisualStyleBackColor = False
        '
        'pnlSup
        '
        Me.pnlSup.Controls.Add(Me.pnlSupLeft)
        Me.pnlSup.Controls.Add(Me.pnlSupRight)
        Me.pnlSup.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSup.Location = New System.Drawing.Point(0, 0)
        Me.pnlSup.Name = "pnlSup"
        Me.pnlSup.Size = New System.Drawing.Size(1264, 25)
        Me.pnlSup.TabIndex = 12
        '
        'pnlSupLeft
        '
        Me.pnlSupLeft.Controls.Add(Me.ms)
        Me.pnlSupLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSupLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlSupLeft.Name = "pnlSupLeft"
        Me.pnlSupLeft.Size = New System.Drawing.Size(713, 25)
        Me.pnlSupLeft.TabIndex = 6
        '
        'ms
        '
        Me.ms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem3, Me.ToolStripMenuItem8, Me.ToolStripMenuItem14, Me.ToolStripMenuItem19, Me.ToolStripMenuItem21, Me.ToolStripMenuItem26, Me.ToolStripMenuItem29, Me.ToolStripMenuItem33, Me.ToolStripMenuItem37})
        Me.ms.Location = New System.Drawing.Point(0, 0)
        Me.ms.Name = "ms"
        Me.ms.Size = New System.Drawing.Size(713, 25)
        Me.ms.TabIndex = 1
        Me.ms.Text = "menu"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 21)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(92, 22)
        Me.ToolStripMenuItem2.Text = "Exit"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(71, 21)
        Me.ToolStripMenuItem3.Text = "Company"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem4.Text = "CompanySelection"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem5.Text = "UserSelection"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem6.Text = "Configuration"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem7.Text = "SecurityCopy"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11, Me.ToolStripMenuItem12, Me.ToolStripMenuItem13})
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(40, 21)
        Me.ToolStripMenuItem8.Text = "Sale"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripMenuItem9.Text = "Budget"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripMenuItem10.Text = "Service Order"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripMenuItem11.Text = "Order"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripMenuItem12.Text = "Delivery"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripMenuItem13.Text = "Bill"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem15, Me.ToolStripMenuItem16, Me.ToolStripMenuItem17, Me.ToolStripMenuItem18})
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(39, 21)
        Me.ToolStripMenuItem14.Text = "Buy"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(139, 22)
        Me.ToolStripMenuItem15.Text = "Budget Buy"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(139, 22)
        Me.ToolStripMenuItem16.Text = "Order Buy"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(139, 22)
        Me.ToolStripMenuItem17.Text = "Delivery Buy"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(139, 22)
        Me.ToolStripMenuItem18.Text = "Bill Buy"
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem20})
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(46, 21)
        Me.ToolStripMenuItem19.Text = "Diary"
        '
        'ToolStripMenuItem20
        '
        Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
        Me.ToolStripMenuItem20.Size = New System.Drawing.Size(101, 22)
        Me.ToolStripMenuItem20.Text = "Diary"
        '
        'ToolStripMenuItem21
        '
        Me.ToolStripMenuItem21.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem22, Me.ToolStripMenuItem23, Me.ToolStripMenuItem24, Me.ToolStripMenuItem25})
        Me.ToolStripMenuItem21.Name = "ToolStripMenuItem21"
        Me.ToolStripMenuItem21.Size = New System.Drawing.Size(140, 21)
        Me.ToolStripMenuItem21.Text = "Supplier and Customer"
        '
        'ToolStripMenuItem22
        '
        Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
        Me.ToolStripMenuItem22.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripMenuItem22.Text = "Customer"
        '
        'ToolStripMenuItem23
        '
        Me.ToolStripMenuItem23.Name = "ToolStripMenuItem23"
        Me.ToolStripMenuItem23.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripMenuItem23.Text = "Distributor"
        '
        'ToolStripMenuItem24
        '
        Me.ToolStripMenuItem24.Name = "ToolStripMenuItem24"
        Me.ToolStripMenuItem24.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripMenuItem24.Text = "Supplier"
        '
        'ToolStripMenuItem25
        '
        Me.ToolStripMenuItem25.Name = "ToolStripMenuItem25"
        Me.ToolStripMenuItem25.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripMenuItem25.Text = "Activity"
        '
        'ToolStripMenuItem26
        '
        Me.ToolStripMenuItem26.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem27, Me.ToolStripMenuItem28})
        Me.ToolStripMenuItem26.Name = "ToolStripMenuItem26"
        Me.ToolStripMenuItem26.Size = New System.Drawing.Size(81, 21)
        Me.ToolStripMenuItem26.Text = "Accounting"
        '
        'ToolStripMenuItem27
        '
        Me.ToolStripMenuItem27.Name = "ToolStripMenuItem27"
        Me.ToolStripMenuItem27.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem27.Text = "Accounting Plan"
        '
        'ToolStripMenuItem28
        '
        Me.ToolStripMenuItem28.Name = "ToolStripMenuItem28"
        Me.ToolStripMenuItem28.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem28.Text = "Summary of VAT"
        '
        'ToolStripMenuItem29
        '
        Me.ToolStripMenuItem29.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem30, Me.ToolStripMenuItem31, Me.ToolStripMenuItem32})
        Me.ToolStripMenuItem29.Name = "ToolStripMenuItem29"
        Me.ToolStripMenuItem29.Size = New System.Drawing.Size(48, 21)
        Me.ToolStripMenuItem29.Text = "Stock"
        '
        'ToolStripMenuItem30
        '
        Me.ToolStripMenuItem30.Name = "ToolStripMenuItem30"
        Me.ToolStripMenuItem30.Size = New System.Drawing.Size(171, 22)
        Me.ToolStripMenuItem30.Text = "Store"
        '
        'ToolStripMenuItem31
        '
        Me.ToolStripMenuItem31.Name = "ToolStripMenuItem31"
        Me.ToolStripMenuItem31.Size = New System.Drawing.Size(171, 22)
        Me.ToolStripMenuItem31.Text = "Stock Movements"
        '
        'ToolStripMenuItem32
        '
        Me.ToolStripMenuItem32.Name = "ToolStripMenuItem32"
        Me.ToolStripMenuItem32.Size = New System.Drawing.Size(171, 22)
        Me.ToolStripMenuItem32.Text = "Summary of Stock"
        '
        'ToolStripMenuItem33
        '
        Me.ToolStripMenuItem33.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem34, Me.ToolStripMenuItem35, Me.ToolStripMenuItem36})
        Me.ToolStripMenuItem33.Name = "ToolStripMenuItem33"
        Me.ToolStripMenuItem33.Size = New System.Drawing.Size(58, 21)
        Me.ToolStripMenuItem33.Text = "Articles"
        '
        'ToolStripMenuItem34
        '
        Me.ToolStripMenuItem34.Name = "ToolStripMenuItem34"
        Me.ToolStripMenuItem34.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem34.Text = "Articles"
        '
        'ToolStripMenuItem35
        '
        Me.ToolStripMenuItem35.Name = "ToolStripMenuItem35"
        Me.ToolStripMenuItem35.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem35.Text = "SubFamily"
        '
        'ToolStripMenuItem36
        '
        Me.ToolStripMenuItem36.Name = "ToolStripMenuItem36"
        Me.ToolStripMenuItem36.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem36.Text = "Family"
        '
        'ToolStripMenuItem37
        '
        Me.ToolStripMenuItem37.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem38, Me.ToolStripMenuItem39, Me.ToolStripMenuItem40, Me.ToolStripMenuItem41, Me.ToolStripMenuItem42, Me.ToolStripMenuItem43, Me.ToolStripMenuItem44})
        Me.ToolStripMenuItem37.Name = "ToolStripMenuItem37"
        Me.ToolStripMenuItem37.Size = New System.Drawing.Size(84, 21)
        Me.ToolStripMenuItem37.Text = "Point of sale"
        '
        'ToolStripMenuItem38
        '
        Me.ToolStripMenuItem38.Name = "ToolStripMenuItem38"
        Me.ToolStripMenuItem38.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem38.Text = "PS Budget"
        '
        'ToolStripMenuItem39
        '
        Me.ToolStripMenuItem39.Name = "ToolStripMenuItem39"
        Me.ToolStripMenuItem39.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem39.Text = "PS Order"
        '
        'ToolStripMenuItem40
        '
        Me.ToolStripMenuItem40.Name = "ToolStripMenuItem40"
        Me.ToolStripMenuItem40.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem40.Text = "PS Delivery"
        '
        'ToolStripMenuItem41
        '
        Me.ToolStripMenuItem41.Name = "ToolStripMenuItem41"
        Me.ToolStripMenuItem41.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem41.Text = "PS Ticket"
        '
        'ToolStripMenuItem42
        '
        Me.ToolStripMenuItem42.Name = "ToolStripMenuItem42"
        Me.ToolStripMenuItem42.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem42.Text = "PS Bill"
        '
        'ToolStripMenuItem43
        '
        Me.ToolStripMenuItem43.Name = "ToolStripMenuItem43"
        Me.ToolStripMenuItem43.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem43.Text = "Closing cash"
        '
        'ToolStripMenuItem44
        '
        Me.ToolStripMenuItem44.Name = "ToolStripMenuItem44"
        Me.ToolStripMenuItem44.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem44.Text = "Historical tickets"
        '
        'pnlSupRight
        '
        Me.pnlSupRight.Controls.Add(Me.lbCurrentUser)
        Me.pnlSupRight.Controls.Add(Me.lbCurrentCompany)
        Me.pnlSupRight.Controls.Add(Me.lbCompany)
        Me.pnlSupRight.Controls.Add(Me.lbUser)
        Me.pnlSupRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlSupRight.Location = New System.Drawing.Point(943, 0)
        Me.pnlSupRight.Name = "pnlSupRight"
        Me.pnlSupRight.Size = New System.Drawing.Size(321, 25)
        Me.pnlSupRight.TabIndex = 5
        '
        'lbCurrentUser
        '
        Me.lbCurrentUser.AutoSize = True
        Me.lbCurrentUser.BackColor = System.Drawing.SystemColors.Window
        Me.lbCurrentUser.Location = New System.Drawing.Point(52, 8)
        Me.lbCurrentUser.Name = "lbCurrentUser"
        Me.lbCurrentUser.Size = New System.Drawing.Size(70, 13)
        Me.lbCurrentUser.TabIndex = 6
        Me.lbCurrentUser.Text = "Administrador"
        '
        'lbCurrentCompany
        '
        Me.lbCurrentCompany.AutoSize = True
        Me.lbCurrentCompany.BackColor = System.Drawing.SystemColors.Window
        Me.lbCurrentCompany.Location = New System.Drawing.Point(204, 8)
        Me.lbCurrentCompany.Name = "lbCurrentCompany"
        Me.lbCurrentCompany.Size = New System.Drawing.Size(73, 13)
        Me.lbCurrentCompany.TabIndex = 5
        Me.lbCurrentCompany.Text = "gestdb0Demo"
        '
        'lbCompany
        '
        Me.lbCompany.AutoSize = True
        Me.lbCompany.Location = New System.Drawing.Point(144, 8)
        Me.lbCompany.Name = "lbCompany"
        Me.lbCompany.Size = New System.Drawing.Size(54, 13)
        Me.lbCompany.TabIndex = 7
        Me.lbCompany.Text = "Company:"
        '
        'lbUser
        '
        Me.lbUser.AutoSize = True
        Me.lbUser.Location = New System.Drawing.Point(3, 8)
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(32, 13)
        Me.lbUser.TabIndex = 2
        Me.lbUser.Text = "User:"
        '
        'FrMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 762)
        Me.Controls.Add(Me.pnlSup)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlInf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Name = "FrMain"
        Me.Text = "FrMain"
        Me.pnlInf.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        CType(Me.nb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nb.ResumeLayout(False)
        Me.nb5SupAndCust.ResumeLayout(False)
        Me.nb2Sale.ResumeLayout(False)
        Me.nb1Company.ResumeLayout(False)
        Me.nb3Buy.ResumeLayout(False)
        Me.nb4Diary.ResumeLayout(False)
        Me.nb6Accounting.ResumeLayout(False)
        Me.nb7Stock.ResumeLayout(False)
        Me.nb8Articles.ResumeLayout(False)
        Me.nb9PointOfSale.ResumeLayout(False)
        CType(Me.nGSupAndCust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nGSupAndCust.ResumeLayout(False)
        CType(Me.nGSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nGSale.ResumeLayout(False)
        CType(Me.nGCompany, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nGCompany.ResumeLayout(False)
        CType(Me.nGBuy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nGBuy.ResumeLayout(False)
        CType(Me.nGDiary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nGDiary.ResumeLayout(False)
        CType(Me.nGAccounting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nGAccounting.ResumeLayout(False)
        CType(Me.nGStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nGStock.ResumeLayout(False)
        CType(Me.nGArticles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nGArticles.ResumeLayout(False)
        CType(Me.nGPointOfSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nGPointOfSale.ResumeLayout(False)
        Me.pnlSup.ResumeLayout(False)
        Me.pnlSupLeft.ResumeLayout(False)
        Me.pnlSupLeft.PerformLayout()
        Me.ms.ResumeLayout(False)
        Me.ms.PerformLayout()
        Me.pnlSupRight.ResumeLayout(False)
        Me.pnlSupRight.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents msFile As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msFExit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msCompany As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msCCompanyselection As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msCUserselection As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msCConfiguration As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msCSecuritycopy As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msSale As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msSBudget As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msSServiceOrder As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msSOrder As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msSDelivery As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msSBill As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msBuy As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msBBudgetBuy As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msBOrderBuy As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msBDeliveryBuy As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msBBillbuy As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msDiary As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msDDiary As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msSupplierandcustomer As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msSCustomer As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msSDistributor As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msSSupplier As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msSActivity As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msAccounting As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msAAccountingPlan As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msASummaryofvat As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msStock As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msSStore As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msSStockmovements As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msSSummaryofstock As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msArticles As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msAArticles As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msASubfamily As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msAFamily As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msPointofsale As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msPPsbudget As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msPPsOrder As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msPPsdelivery As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msPPsticket As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msPPsbill As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msPClosingcash As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents msPHistoricaltickets As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pnlInf As System.Windows.Forms.Panel
    Private WithEvents prgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Private WithEvents pnlRight As System.Windows.Forms.Panel
    Private WithEvents pnlLeft As System.Windows.Forms.Panel
    Private WithEvents nb As Guifreaks.NavigationBar.NaviBar
    Private WithEvents nb5SupAndCust As Guifreaks.NavigationBar.NaviBand
    Private WithEvents nGSupAndCust As Guifreaks.NavigationBar.NaviGroup
    Private WithEvents btt4Activity As System.Windows.Forms.Button
    Private WithEvents btt3Supplier As System.Windows.Forms.Button
    Private WithEvents btt2Distributor As System.Windows.Forms.Button
    Private WithEvents btt1Customer As System.Windows.Forms.Button
    Private WithEvents nb1Company As Guifreaks.NavigationBar.NaviBand
    Private WithEvents nGCompany As Guifreaks.NavigationBar.NaviGroup
    Private WithEvents btt4SecurityCopy As System.Windows.Forms.Button
    Private WithEvents btt3Configuration As System.Windows.Forms.Button
    Private WithEvents btt2UserSelection As System.Windows.Forms.Button
    Private WithEvents btt1CompanySelection As System.Windows.Forms.Button
    Private WithEvents nb3Buy As Guifreaks.NavigationBar.NaviBand
    Private WithEvents nGBuy As Guifreaks.NavigationBar.NaviGroup
    Private WithEvents btt4BillBuy As System.Windows.Forms.Button
    Private WithEvents btt3DeliveryBuy As System.Windows.Forms.Button
    Private WithEvents btt2OrderBuy As System.Windows.Forms.Button
    Private WithEvents btt1BudgetBuy As System.Windows.Forms.Button
    Private WithEvents nb2Sale As Guifreaks.NavigationBar.NaviBand
    Private WithEvents nGSale As Guifreaks.NavigationBar.NaviGroup
    Private WithEvents btt5Bill As System.Windows.Forms.Button
    Private WithEvents btt4Delivery As System.Windows.Forms.Button
    Private WithEvents btt3Order As System.Windows.Forms.Button
    Private WithEvents btt2ServiceOrder As System.Windows.Forms.Button
    Private WithEvents btt1Budget As System.Windows.Forms.Button
    Private WithEvents nb4Diary As Guifreaks.NavigationBar.NaviBand
    Private WithEvents nGDiary As Guifreaks.NavigationBar.NaviGroup
    Private WithEvents btt1Diary As System.Windows.Forms.Button
    Private WithEvents nb6Accounting As Guifreaks.NavigationBar.NaviBand
    Private WithEvents nGAccounting As Guifreaks.NavigationBar.NaviGroup
    Private WithEvents btt2SummaryOfVat As System.Windows.Forms.Button
    Private WithEvents btt1AccountingPlan As System.Windows.Forms.Button
    Private WithEvents nb7Stock As Guifreaks.NavigationBar.NaviBand
    Private WithEvents nGStock As Guifreaks.NavigationBar.NaviGroup
    Private WithEvents btt3SummaryOfStock As System.Windows.Forms.Button
    Private WithEvents btt2StockMovements As System.Windows.Forms.Button
    Private WithEvents btt1Store As System.Windows.Forms.Button
    Private WithEvents nb8Articles As Guifreaks.NavigationBar.NaviBand
    Private WithEvents nGArticles As Guifreaks.NavigationBar.NaviGroup
    Private WithEvents btt3Family As System.Windows.Forms.Button
    Private WithEvents btt2SubFamily As System.Windows.Forms.Button
    Private WithEvents btt1Articles As System.Windows.Forms.Button
    Private WithEvents nb9PointOfSale As Guifreaks.NavigationBar.NaviBand
    Private WithEvents nGPointOfSale As Guifreaks.NavigationBar.NaviGroup
    Private WithEvents btt7HistoricalTickets As System.Windows.Forms.Button
    Private WithEvents btt6ClosingCash As System.Windows.Forms.Button
    Private WithEvents btt5PsBill As System.Windows.Forms.Button
    Private WithEvents btt4PsTicket As System.Windows.Forms.Button
    Private WithEvents btt3PsDelivery As System.Windows.Forms.Button
    Private WithEvents btt2PsOrder As System.Windows.Forms.Button
    Private WithEvents btt1PsBudget As System.Windows.Forms.Button
    Private WithEvents pnlSup As System.Windows.Forms.Panel
    Private WithEvents pnlSupLeft As System.Windows.Forms.Panel
    Private WithEvents ms As System.Windows.Forms.MenuStrip
    Private WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem19 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem20 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem21 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem22 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem23 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem24 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem25 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem26 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem27 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem28 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem29 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem30 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem31 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem32 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem33 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem34 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem35 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem36 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem37 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem38 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem39 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem40 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem41 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem42 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem43 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem44 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pnlSupRight As System.Windows.Forms.Panel
    Private WithEvents lbCurrentUser As System.Windows.Forms.Label
    Private WithEvents lbCurrentCompany As System.Windows.Forms.Label
    Private WithEvents lbCompany As System.Windows.Forms.Label
    Private WithEvents lbUser As System.Windows.Forms.Label
End Class
