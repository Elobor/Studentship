SELECT kat_obucheniya AS '��������� ��������', COUNT(*) AS '���������� ����������� � 91 ����'
	FROM poss
		JOIN kat_obuch ON kat_obuch_k=kat_obuch.cod
	WHERE gp=91
	GROUP BY kat_obucheniya