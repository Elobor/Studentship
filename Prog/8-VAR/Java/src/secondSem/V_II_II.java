package secondSem;

import java.sql.*;

public class V_II_II {					// НЕОБХОДИМ ЛОКАЛЬНЫЙ СЕРВЕР SQL (см. V_II_I)

	public static void main(String[] args) throws SQLException {
		Connection con = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databaseName=JavaDB;integratedSecurity=true;");
		Statement ask = con.createStatement();
		ResultSet Q = ask.executeQuery("SELECT fio, book_name FROM javaFTT WHERE (last_queries = '0') AND (publishing_year NOT BETWEEN '1980' AND '2020')");
		while(Q.next()){
			System.out.println(Q.getString(1) + " " + Q.getString(2));
		}
		ask.close();
	}

}
