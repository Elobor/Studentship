SELECT kat_obucheniya AS 'Категория Обучения', COUNT(*) AS 'Количество поступивших в 91 году'
	FROM poss
		JOIN kat_obuch ON kat_obuch_k=kat_obuch.cod
	WHERE gp=91
	GROUP BY kat_obucheniya