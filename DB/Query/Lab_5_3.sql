SELECT COUNT(*)
	FROM poss

SELECT vuz_gorod.nazvanie_goroda, COUNT (*)
	FROM poss
		JOIN vuz_gorod ON vuz_k=vuz_gorod.cod_vuza
	GROUP BY vuz_gorod.nazvanie_goroda