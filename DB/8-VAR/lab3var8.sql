SELECT fio, pol, family_status, spec, uch_zavedenie, kat_obucheniya, mp, gp, mo, gok
	FROM ukr
		JOIN vuz on vuz_k = vuz.cod
		JOIN kat_obuch on kat_obuch_k = kat_obuch.cod 
		JOIN family on sem_polog_k = family.cod
		JOIN vuz_gorod on vuz_k=vuz_gorod.cod_vuza
	WHERE vuz_k = vuz.cod 
		AND kat_obuch_k=kat_obuch.cod 
		AND data_rogden LIKE '%66' 
		AND vuz_gorod.cod_stran = '02'
		AND (kat_obuch.cod = 03 OR kat_obuch.cod = 07)
	ORDER BY uch_zavedenie, kat_obucheniya