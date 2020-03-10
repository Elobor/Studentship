SELECT fio, data_rogden, vuz. uch_zavedenie, pol, family.family_status, spec, kat_obuch. kat_obucheniya, mp, gp, mo, gok
	FROM poss 
		JOIN vuz ON vuz_k=vuz.cod
		JOIN family ON sem_polog_k=family.cod
		JOIN kat_obuch ON kat_obuch_k=kat_obuch.cod
	WHERE (gok='93' OR gok='95')
		AND spec BETWEEN '000701' AND '000705'
	ORDER BY 11, 6, 3
