CREATE PROCEDURE zapr1 AS
	SELECT COUNT(*) 
		FROM poss 
		WHERE gp='90' or gp='91'
	SELECT spec, count(*) 
		FROM poss
		WHERE gp='90' or gp='91' 
		GROUP BY spec
