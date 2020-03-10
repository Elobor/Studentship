CREATE TRIGGER lab9
	ON poss1
	FOR INSERT
	AS
		IF (SELECT COUNT(*) FROM god_pr, inserted
		WHERE god_pr.god = inserted.gp)=0
		SELECT 'значение поля gp не принадлежит домену'


		