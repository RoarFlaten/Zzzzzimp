using System.Transactions;

namespace Data
{

    public static class PaymentProcessor
    {
        public static void ProcessTransaction()
        {
            using (var transscope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    using (Microsoft.Data.SqlClient.SqlConnection objConn = new Microsoft.Data.SqlClient.SqlConnection("strConnString"))
                    {

                        //TODO: update neccecary tables with payment data here
                        objConn.Open();
                        Microsoft.Data.SqlClient.SqlCommand objCmd1 = new Microsoft.Data.SqlClient.SqlCommand("insert into tblTransaction values(1, 'TestProject')", objConn);

                        objCmd1.ExecuteNonQuery();
                        transscope.Complete();
                    }
                }
                catch (Exception ex)
                {
                    // Log error ex.stacktrace()
                    transscope.Dispose();
                }
            }


        }

    }
}
