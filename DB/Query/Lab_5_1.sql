SELECT COUNT(*) AS '���������� ��������'
	FROM poss
	WHERE gp = 90 OR gp = 91

SELECT spec, COUNT(*)
	FROM poss
	WHERE gp = 90 OR gp = 91
	GROUP BY spec