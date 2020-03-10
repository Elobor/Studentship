CREATE TRIGGER autoupdate
	ON vuz_gorod
	AFTER UPDATE
	AS 
	UPDATE vuz 
		SET cod = cod_vuza, uch_zavedenie = nazvanie_vuza
			FROM inserted