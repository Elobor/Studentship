SELECT fio, data_rogden, spec, kat_obuch.kat_obucheniya, vuz.uch_zavedenie, mo, gok
	FROM poss 
		JOIN kat_obuch ON kat_obuch_k=kat_obuch.cod
		JOIN vuz ON vuz_k=vuz.cod
	WHERE vuz_k IN 
	(SELECT cod_vuza 
		FROM vuz_gorod
		WHERE cod_goroda='001')
	AND kat_obuch_k BETWEEN '03' AND '04'
	AND gp='89'
	ORDER BY 5, 3
