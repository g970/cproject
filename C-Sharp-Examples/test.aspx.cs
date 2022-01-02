protected void submit (object sender, EventArgs e)
{
    string query1 = "Select username, password from admin where username <> 'admin' and password = '" + pass.Text.Trim() + "' ";

    try
        {
            DataSet dSet1 = new DataSet();
            dSet1 = fetchWebDB(query1);
        }

    DataSet fetchWebDB(string query)
        {
            // connect to data source
            OleDbConnection myConn = new OleDbConnection("Provider=SQLOLEDB;Data Source=.;Initial Catalog=AMS;User ID=sa;Password=pass@123");
            myConn.Open();
            // initialize dataadapter with query
            OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, myConn);

            // initalize and fill dataset with query results
            DataSet myData = new DataSet();
            myAdapter.Fill(myData);
            myConn.Close();

            // return dataset
            return myData;
        }
}
