SELECT fio AS 'Список Учащихся-Женщин города Киев', data_rogden, spec, kat_obucheniya, nazvanie_vuza, mp, gp, mo, gok, nazvanie_goroda
	FROM ukr
		JOIN vuz ON vuz_k=vuz.cod
		JOIN vuz_gorod ON vuz_k=vuz_gorod.cod_vuza
		JOIN kat_obuch ON kat_obuch_k=kat_obuch.cod
	WHERE pol = 'Ж'
		AND vuz_k in (SELECT cod_vuza FROM vuz_gorod WHERE cod_goroda = 101)
	ORDER BY nazvanie_vuza, ukr.spec