SELECT COUNT(*) AS 'Приём 91-го года'
	FROM ukr
		JOIN kat_obuch ON kat_obuch_k=kat_obuch.cod
	WHERE gp=91