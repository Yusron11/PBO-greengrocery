create a database with the name pbo and run the query in the database file on posgresql

To connect the program to the database, change the password for each method:
return new NpgsqlConnection("server = localhost; port = 5432; username = postgres; password = yourpassword; database = pbo;");

change the password according to your postgresql password
