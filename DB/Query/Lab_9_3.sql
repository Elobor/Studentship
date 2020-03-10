CREATE TRIGGER vuztrig3 
	ON vuz_gorod
	FOR DELETE 
	AS
		IF  (SELECT COUNT(*) FROM deleted)>0
		SELECT 'Необходимо удалить старую запись из таблицы vuz'
