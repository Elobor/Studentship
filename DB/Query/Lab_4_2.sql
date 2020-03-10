SELECT fio, data_rogden, vuz.uch_zavedenie, pol, family.family_status, spec, kat_obuch.kat_obucheniya, mp, gp, mo, gok
	FROM poss 
		JOIN vuz ON vuz_k=vuz.cod
		JOIN family ON sem_polog_k=family.cod
		JOIN kat_obuch ON kat_obuch_k=kat_obuch.cod
	WHERE vuz_k IN 
		(SELECT cod_vuza 
			FROM vuz_gorod
			WHERE cod_goroda='001' OR cod_goroda='002' OR cod_goroda='006')
				AND (kat_obuch_k BETWEEN '07' AND '08' OR kat_obuch_k BETWEEN '10' AND '11')
				AND gok IN ('93', '95')
	ORDER BY 3, 11		
