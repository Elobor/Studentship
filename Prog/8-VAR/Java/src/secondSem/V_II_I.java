package secondSem;

import java.sql.*;


public class V_II_I {								// НЕОБХОДИМ ЛОКАЛЬНЫЙ СЕРВЕР SQL + ДРАЙВЕР JDBC РАЗНЫЙ ДЛЯ РАЗНЫХ ВЕРСИЙ JAVA (тут 7.4.1 java12)
	
	static String instanceName = "FURRY-TRASH-BIN"; // Имя компьютера
	static String databaseName = "JavaDB";			// Имя Базы Данных
	static String userName = "FURRY_TRASH";			// Имя пользователя (не WindowsAuth)
	static String pass = "furfur";					// Пароль
	static String connectionUrl = "jdbc:sqlserver://%1$s;databaseName=%2$s;user=%3$s;password=%4$s;"; // Собираем всё вместе
	static String connectionString = String.format(connectionUrl, instanceName, databaseName, userName, pass);
	
	//static String connectionString = "jdbc:sqlserver://localhost:1433;databaseName=/*!!!DATABASENAME!!!*/;integratedSecurity=true;"; // WindowsAuth

	public static void main(String[] args) throws Exception {
		//System.out.println(connectionString);
		//pingSQL();
		Connection con = DriverManager.getConnection(connectionString);
		//Connection con = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databaseName=JavaDB;integratedSecurity=true;");
		Statement ask = con.createStatement();
		ResultSet Q = ask.executeQuery("SELECT fio, data_rogden, pol,name_of_disciple, mark FROM JavaFiveTwoStudents JOIN JavaFiveTwoMarks ON id = id_stud JOIN JavaFiveTwoDisciples ON id_disciple = id_dis  WHERE data_rogden NOT BETWEEN '2004' AND '2020'  ORDER BY fio, name_of_disciple");
	
        boolean isTheSamePerson = false;
        boolean isTheSameDisc = false;
        String name = new String();
        String disc = new String();
		
		while(Q.next()){
                      
           if (Q.getString(1).equals(name)) {
        	   isTheSamePerson = true;
           } else {
        	   isTheSamePerson = false;
           }
           if (Q.getString(4).equalsIgnoreCase(disc)) {
        	   isTheSameDisc = true;
           } else {
        	   isTheSameDisc = false;
           }
           
           if (isTheSamePerson) {
        	   if (isTheSameDisc) {
        		   System.out.print(Q.getString(5) + " ");
        	   } else {
        		   System.out.println();
        		   System.out.print(Q.getString(4));
        		   System.out.print(Q.getString(5) + " ");
        	   }
           } else {
        	   System.out.print("\n" + Q.getString(1) + " " + Q.getString(2) + " года рождения (" + Q.getString(3) + ")\n");
        	   System.out.print(Q.getString(4));
        	   System.out.print(Q.getString(5) + " ");
           }
           
           name = Q.getString(1);
           disc = Q.getString(4);
           
		}
	}
	
	public static void pingSQL() throws Exception {
		Connection con = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databaseName=JavaDB;integratedSecurity=true;");
		Statement ask = con.createStatement();
		if (ask.isClosed()) {
			System.out.print("Ha! Pathetic...");
		} else {
			System.out.print("ping!");
		};
		con.close();
	}
	
	public static void CreateTablesV_II() throws Exception {
		Connection con = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databaseName=JavaDB;integratedSecurity=true;");
		Statement ask = con.createStatement();
		ask.execute("CREATE TABLE JavaFiveTwoStudents (id char(6), fio char(60) not null, data_rogden char(6), pol char(1))");
		ask.execute("CREATE TABLE JavaFiveTwoMarks (id_stud char(6), id_disciple char(2), mark char(1))");
		ask.execute("CREATE TABLE JavaFiveTwoDisciples (id_dis char(2), name_of_disciple char(15))");
		con.close();
	}
}