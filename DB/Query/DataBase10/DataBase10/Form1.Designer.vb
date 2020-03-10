<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDatabase
	Inherits System.Windows.Forms.Form

	'Форма переопределяет dispose для очистки списка компонентов.
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

	'Является обязательной для конструктора форм Windows Forms
	Private components As System.ComponentModel.IContainer

	'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
	'Для ее изменения используйте конструктор форм Windows Form.  
	'Не изменяйте ее в редакторе исходного кода.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.NomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DatarogdenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SempologkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SpecDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.KatobuchkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.VuzkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.GpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.GokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PossBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.StudentDataSet = New DataBase10.StudentDataSet()
		Me.PossTableAdapter = New DataBase10.StudentDataSetTableAdapters.possTableAdapter()
		Me.DataGridView2 = New System.Windows.Forms.DataGridView()
		Me.CodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.KatobucheniyaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.KatobuchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.Kat_obuchTableAdapter = New DataBase10.StudentDataSetTableAdapters.kat_obuchTableAdapter()
		Me.DataGridView3 = New System.Windows.Forms.DataGridView()
		Me.CodDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.UchzavedenieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.VuzBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.VuzTableAdapter = New DataBase10.StudentDataSetTableAdapters.vuzTableAdapter()
		Me.comboxKatObuch = New System.Windows.Forms.ComboBox()
		Me.KatobuchBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.comboxVUZ = New System.Windows.Forms.ComboBox()
		Me.VuzBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PossBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.KatobuchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.VuzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.KatobuchBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.VuzBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomerDataGridViewTextBoxColumn, Me.FioDataGridViewTextBoxColumn, Me.DatarogdenDataGridViewTextBoxColumn, Me.PolDataGridViewTextBoxColumn, Me.SempologkDataGridViewTextBoxColumn, Me.SpecDataGridViewTextBoxColumn, Me.KatobuchkDataGridViewTextBoxColumn, Me.VuzkDataGridViewTextBoxColumn, Me.MpDataGridViewTextBoxColumn, Me.GpDataGridViewTextBoxColumn, Me.MoDataGridViewTextBoxColumn, Me.GokDataGridViewTextBoxColumn})
		Me.DataGridView1.DataSource = Me.PossBindingSource
		Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(1244, 257)
		Me.DataGridView1.TabIndex = 0
		'
		'NomerDataGridViewTextBoxColumn
		'
		Me.NomerDataGridViewTextBoxColumn.DataPropertyName = "nomer"
		Me.NomerDataGridViewTextBoxColumn.HeaderText = "Номер"
		Me.NomerDataGridViewTextBoxColumn.Name = "NomerDataGridViewTextBoxColumn"
		'
		'FioDataGridViewTextBoxColumn
		'
		Me.FioDataGridViewTextBoxColumn.DataPropertyName = "fio"
		Me.FioDataGridViewTextBoxColumn.HeaderText = "Ф.И.О."
		Me.FioDataGridViewTextBoxColumn.Name = "FioDataGridViewTextBoxColumn"
		'
		'DatarogdenDataGridViewTextBoxColumn
		'
		Me.DatarogdenDataGridViewTextBoxColumn.DataPropertyName = "data_rogden"
		Me.DatarogdenDataGridViewTextBoxColumn.HeaderText = "Дата Рождения"
		Me.DatarogdenDataGridViewTextBoxColumn.Name = "DatarogdenDataGridViewTextBoxColumn"
		'
		'PolDataGridViewTextBoxColumn
		'
		Me.PolDataGridViewTextBoxColumn.DataPropertyName = "pol"
		Me.PolDataGridViewTextBoxColumn.HeaderText = "Пол"
		Me.PolDataGridViewTextBoxColumn.Name = "PolDataGridViewTextBoxColumn"
		'
		'SempologkDataGridViewTextBoxColumn
		'
		Me.SempologkDataGridViewTextBoxColumn.DataPropertyName = "sem_polog_k"
		Me.SempologkDataGridViewTextBoxColumn.HeaderText = "Код Семейного Положения"
		Me.SempologkDataGridViewTextBoxColumn.Name = "SempologkDataGridViewTextBoxColumn"
		'
		'SpecDataGridViewTextBoxColumn
		'
		Me.SpecDataGridViewTextBoxColumn.DataPropertyName = "spec"
		Me.SpecDataGridViewTextBoxColumn.HeaderText = "Код Специальности"
		Me.SpecDataGridViewTextBoxColumn.Name = "SpecDataGridViewTextBoxColumn"
		'
		'KatobuchkDataGridViewTextBoxColumn
		'
		Me.KatobuchkDataGridViewTextBoxColumn.DataPropertyName = "kat_obuch_k"
		Me.KatobuchkDataGridViewTextBoxColumn.HeaderText = "Код Категории Обучения"
		Me.KatobuchkDataGridViewTextBoxColumn.Name = "KatobuchkDataGridViewTextBoxColumn"
		'
		'VuzkDataGridViewTextBoxColumn
		'
		Me.VuzkDataGridViewTextBoxColumn.DataPropertyName = "vuz_k"
		Me.VuzkDataGridViewTextBoxColumn.HeaderText = "Код ВУЗа"
		Me.VuzkDataGridViewTextBoxColumn.Name = "VuzkDataGridViewTextBoxColumn"
		'
		'MpDataGridViewTextBoxColumn
		'
		Me.MpDataGridViewTextBoxColumn.DataPropertyName = "mp"
		Me.MpDataGridViewTextBoxColumn.HeaderText = "Месяц Приёма"
		Me.MpDataGridViewTextBoxColumn.Name = "MpDataGridViewTextBoxColumn"
		'
		'GpDataGridViewTextBoxColumn
		'
		Me.GpDataGridViewTextBoxColumn.DataPropertyName = "gp"
		Me.GpDataGridViewTextBoxColumn.HeaderText = "Год Приёма"
		Me.GpDataGridViewTextBoxColumn.Name = "GpDataGridViewTextBoxColumn"
		'
		'MoDataGridViewTextBoxColumn
		'
		Me.MoDataGridViewTextBoxColumn.DataPropertyName = "mo"
		Me.MoDataGridViewTextBoxColumn.HeaderText = "Месяц Окончания"
		Me.MoDataGridViewTextBoxColumn.Name = "MoDataGridViewTextBoxColumn"
		'
		'GokDataGridViewTextBoxColumn
		'
		Me.GokDataGridViewTextBoxColumn.DataPropertyName = "gok"
		Me.GokDataGridViewTextBoxColumn.HeaderText = "Год Окончания"
		Me.GokDataGridViewTextBoxColumn.Name = "GokDataGridViewTextBoxColumn"
		'
		'PossBindingSource
		'
		Me.PossBindingSource.DataMember = "poss"
		Me.PossBindingSource.DataSource = Me.StudentDataSet
		Me.PossBindingSource.Filter = ""
		Me.PossBindingSource.Sort = "fio"
		'
		'StudentDataSet
		'
		Me.StudentDataSet.DataSetName = "StudentDataSet"
		Me.StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'PossTableAdapter
		'
		Me.PossTableAdapter.ClearBeforeFill = True
		'
		'DataGridView2
		'
		Me.DataGridView2.AutoGenerateColumns = False
		Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodDataGridViewTextBoxColumn, Me.KatobucheniyaDataGridViewTextBoxColumn})
		Me.DataGridView2.DataSource = Me.KatobuchBindingSource
		Me.DataGridView2.Location = New System.Drawing.Point(12, 275)
		Me.DataGridView2.Name = "DataGridView2"
		Me.DataGridView2.Size = New System.Drawing.Size(357, 244)
		Me.DataGridView2.TabIndex = 1
		'
		'CodDataGridViewTextBoxColumn
		'
		Me.CodDataGridViewTextBoxColumn.DataPropertyName = "cod"
		Me.CodDataGridViewTextBoxColumn.HeaderText = "Код Категории Обучения"
		Me.CodDataGridViewTextBoxColumn.Name = "CodDataGridViewTextBoxColumn"
		'
		'KatobucheniyaDataGridViewTextBoxColumn
		'
		Me.KatobucheniyaDataGridViewTextBoxColumn.DataPropertyName = "kat_obucheniya"
		Me.KatobucheniyaDataGridViewTextBoxColumn.HeaderText = "Категория Обучения"
		Me.KatobucheniyaDataGridViewTextBoxColumn.Name = "KatobucheniyaDataGridViewTextBoxColumn"
		'
		'KatobuchBindingSource
		'
		Me.KatobuchBindingSource.DataMember = "kat_obuch"
		Me.KatobuchBindingSource.DataSource = Me.StudentDataSet
		'
		'Kat_obuchTableAdapter
		'
		Me.Kat_obuchTableAdapter.ClearBeforeFill = True
		'
		'DataGridView3
		'
		Me.DataGridView3.AutoGenerateColumns = False
		Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodDataGridViewTextBoxColumn1, Me.UchzavedenieDataGridViewTextBoxColumn})
		Me.DataGridView3.DataSource = Me.VuzBindingSource
		Me.DataGridView3.Location = New System.Drawing.Point(899, 275)
		Me.DataGridView3.Name = "DataGridView3"
		Me.DataGridView3.Size = New System.Drawing.Size(357, 244)
		Me.DataGridView3.TabIndex = 2
		'
		'CodDataGridViewTextBoxColumn1
		'
		Me.CodDataGridViewTextBoxColumn1.DataPropertyName = "cod"
		Me.CodDataGridViewTextBoxColumn1.HeaderText = "Код ВУЗа"
		Me.CodDataGridViewTextBoxColumn1.Name = "CodDataGridViewTextBoxColumn1"
		'
		'UchzavedenieDataGridViewTextBoxColumn
		'
		Me.UchzavedenieDataGridViewTextBoxColumn.DataPropertyName = "uch_zavedenie"
		Me.UchzavedenieDataGridViewTextBoxColumn.HeaderText = "ВУЗ"
		Me.UchzavedenieDataGridViewTextBoxColumn.Name = "UchzavedenieDataGridViewTextBoxColumn"
		'
		'VuzBindingSource
		'
		Me.VuzBindingSource.DataMember = "vuz"
		Me.VuzBindingSource.DataSource = Me.StudentDataSet
		'
		'VuzTableAdapter
		'
		Me.VuzTableAdapter.ClearBeforeFill = True
		'
		'comboxKatObuch
		'
		Me.comboxKatObuch.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.KatobuchBindingSource1, "cod", True))
		Me.comboxKatObuch.DataSource = Me.KatobuchBindingSource
		Me.comboxKatObuch.DisplayMember = "cod"
		Me.comboxKatObuch.FormattingEnabled = True
		Me.comboxKatObuch.Location = New System.Drawing.Point(653, 275)
		Me.comboxKatObuch.Name = "comboxKatObuch"
		Me.comboxKatObuch.Size = New System.Drawing.Size(101, 21)
		Me.comboxKatObuch.TabIndex = 3
		Me.comboxKatObuch.ValueMember = "cod"
		'
		'KatobuchBindingSource1
		'
		Me.KatobuchBindingSource1.DataMember = "kat_obuch"
		Me.KatobuchBindingSource1.DataSource = Me.StudentDataSet
		'
		'comboxVUZ
		'
		Me.comboxVUZ.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VuzBindingSource1, "cod", True))
		Me.comboxVUZ.DataSource = Me.VuzBindingSource
		Me.comboxVUZ.DisplayMember = "cod"
		Me.comboxVUZ.FormattingEnabled = True
		Me.comboxVUZ.Location = New System.Drawing.Point(760, 275)
		Me.comboxVUZ.Name = "comboxVUZ"
		Me.comboxVUZ.Size = New System.Drawing.Size(100, 21)
		Me.comboxVUZ.TabIndex = 4
		Me.comboxVUZ.ValueMember = "cod"
		'
		'VuzBindingSource1
		'
		Me.VuzBindingSource1.DataMember = "vuz"
		Me.VuzBindingSource1.DataSource = Me.StudentDataSet
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(404, 307)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(93, 13)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Поиск по Ф.И.О."
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(407, 275)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(240, 20)
		Me.TextBox1.TabIndex = 6
		'
		'FormDatabase
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1269, 529)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.comboxVUZ)
		Me.Controls.Add(Me.comboxKatObuch)
		Me.Controls.Add(Me.DataGridView3)
		Me.Controls.Add(Me.DataGridView2)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "FormDatabase"
		Me.Text = "База Данных"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PossBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.KatobuchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.VuzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.KatobuchBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.VuzBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents StudentDataSet As StudentDataSet
	Friend WithEvents PossBindingSource As BindingSource
	Friend WithEvents PossTableAdapter As StudentDataSetTableAdapters.possTableAdapter
	Friend WithEvents DataGridView2 As DataGridView
	Friend WithEvents KatobuchBindingSource As BindingSource
	Friend WithEvents Kat_obuchTableAdapter As StudentDataSetTableAdapters.kat_obuchTableAdapter
	Friend WithEvents DataGridView3 As DataGridView
	Friend WithEvents VuzBindingSource As BindingSource
	Friend WithEvents VuzTableAdapter As StudentDataSetTableAdapters.vuzTableAdapter
	Friend WithEvents NomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents FioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents DatarogdenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SempologkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SpecDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents KatobuchkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents VuzkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents MpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents GpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents MoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents GokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents KatobucheniyaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CodDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	Friend WithEvents UchzavedenieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents comboxKatObuch As ComboBox
	Friend WithEvents KatobuchBindingSource1 As BindingSource
	Friend WithEvents comboxVUZ As ComboBox
	Friend WithEvents VuzBindingSource1 As BindingSource
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox1 As TextBox
End Class
