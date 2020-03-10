CREATE TRIGGER autodelete
	ON vuz_gorod
	AFTER DELETE
	AS 
	DELETE FROM vuz 
		WHERE 
			cod = (SELECT cod_vuza
						FROM inserted)