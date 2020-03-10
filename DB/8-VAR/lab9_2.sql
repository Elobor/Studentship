CREATE TRIGGER autoinsert
	ON vuz_gorod
	AFTER INSERT
	AS 
	INSERT INTO vuz 
		SELECT cod_vuza, nazvanie_vuza
			FROM inserted