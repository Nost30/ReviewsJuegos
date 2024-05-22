Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Namespace ReviewsJuegos
    Public Class ConexionSQL
        Private Shared cnx As SqlConnection = New SqlConnection()
        Private Shared Sub Connect()
            Try
                cnx.ConnectionString = "Data Source=localhost; Initial Catalog=ReviewJuego;Integrated Security=True"
                Call cnx.Open()
            Catch ex As Exception
                MsgBox("Error al conectar a la base de datos: " & ex.Message)
            End Try
        End Sub
        Private Shared Sub Disconect()
            Try
                If cnx.State = ConnectionState.Open Then
                    Call cnx.Close()
                End If
            Catch ex As Exception
                MsgBox("Error al desconectar de la base de datos: " & ex.Message)
            End Try
        End Sub
        ' Create a method to excecute a Selection query
        Public Shared Function SelectQuery(query As String) As DataTable
            Dim dt = New DataTable()
            Try
                Call Connect()
                Dim cmd = New SqlCommand(query, cnx)
                Dim da = New SqlDataAdapter(cmd)
                da.Fill(dt)
            Catch ex As Exception
                MsgBox("Error al ejecutar la consulta: " & ex.Message)
            Finally
                Call Disconect()
            End Try
            Return dt
            ' Método para ejecutar un procedimiento almacenado
        End Function

                ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
''' Nombre del parámetro: node
''' Valor actual not null.
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertToVariableDeclaratorOrNull(IsPatternExpressionSyntax node)
'''    en System.Linq.Enumerable.WhereSelectListIterator`2.MoveNext()
'''    en System.Linq.Enumerable.WhereEnumerableIterator`1.MoveNext()
'''    en System.Linq.Enumerable.<ConcatIterator>d__59`1.MoveNext()
'''    en System.Linq.Buffer`1..ctor(IEnumerable`1 source)
'''    en System.Linq.Enumerable.ToArray[TSource](IEnumerable`1 source)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertToDeclarationStatement(List`1 des, List`1 isPatternExpressions)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.InsertRequiredDeclarations(SyntaxList`1 convertedStatements, CSharpSyntaxNode originaNode)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertStatement(StatementSyntax statement, CSharpSyntaxVisitor`1 methodBodyVisitor)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.<>c__DisplayClass10_0.<ConvertStatements>b__0(StatementSyntax s)
'''    en System.Linq.Enumerable.<SelectManyIterator>d__17`2.MoveNext()
'''    en Microsoft.CodeAnalysis.SyntaxList`1.CreateNode(IEnumerable`1 nodes)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertStatements(SyntaxList`1 statements, MethodBodyExecutableStatementVisitor iteratorState)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertBody(BlockSyntax body, ArrowExpressionClauseSyntax expressionBody, Boolean hasReturnType, MethodBodyExecutableStatementVisitor iteratorState)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''         // Método para ejecutar un procedimiento almacenado
'''         public static void ExecuteStoredProcedure(string procedureName, System.Data.SqlClient.SqlParameter[] parameters = null)
'''         {
''' 
'''             try
'''             {
'''                 ReviewsJuegos.ConexionSQL.Connect();
'''                 var cmd = new System.Data.SqlClient.SqlCommand(procedureName, ReviewsJuegos.ConexionSQL.cnx);
'''                 cmd.CommandType = System.Data.CommandType.StoredProcedure;
'''                 if (parameters is not null)
'''                 {
'''                     cmd.Parameters.AddRange(parameters);
'''                 }
'''                 cmd.ExecuteNonQuery();
'''             }
'''             catch (System.Exception ex)
'''             {
'''                 Microsoft.VisualBasic.Interaction.MsgBox("Error al ejecutar el procedimiento almacenado: " + ex.Message);
'''             }
'''             finally
'''             {
'''                 ReviewsJuegos.ConexionSQL.Disconect();
'''             }
'''         }
''' 
''' 
    End Class
End Namespace
