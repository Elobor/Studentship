CREATE TRIGGER vuztrig2 
	ON vuz_gorod
	FOR INSERT 
	AS
		IF  (SELECT COUNT(*) FROM inserted)>0
		SELECT 'Необходимо добавить запись в таблицу vuz'