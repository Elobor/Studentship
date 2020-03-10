CREATE TRIGGER vuzTrig1 
	ON vuz
	FOR INSERT, UPDATE, DELETE
	AS
		SELECT 'Необходимо внести соответствующие изменения в таблицу vuz_gorod'