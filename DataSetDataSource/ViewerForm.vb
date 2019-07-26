Imports System.Data
Imports System.IO
Public Class ViewerForm
    ' レポートをロードして表示します。
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim rptPath As New FileInfo("..\..\Invoice.rdlx")
        Dim definition As New PageReport(rptPath)
		AddHandler definition.Document.LocateDataSource, AddressOf OnLocateDataSource
		arvMain.LoadDocument(definition.Document)
	End Sub
    ' 実行時にLocateDataSourceイベントと共に、データセットプロバイダを使用し、アンバウンドデータソースと接続できます。LocateDataSourceイベントがデータの入力が必要な場合は、レポートエンジンにより発生されます。
    Private Sub OnLocateDataSource(ByVal sender As Object, ByVal args As LocateDataSourceEventArgs)

        ' DBクラス作成
        Dim db = New ClassSQLite
        Dim tbl = New DataTable

        ' DBにParameterを追加
        'db.ParameterClear()
        'db.AddParameter("@売上伝票no", salesno)
        'db.AddParameter("@入力日付", inputdate)

        ' DataTableを取得
        tbl = db.GetTableObject("select * from sales")

        '印字済みにする
        'db.SqlExecute(uq)


        args.Data = tbl
    End Sub

End Class
