SELECT fio, data_rogden, vuz.uch_zavedenie, pol, spec, kat_obuch. kat_obucheniya, mo, gok
	FROM poss, vuz, kat_obuch
	WHERE gp='91'
	AND vuz_k=vuz.cod
	AND kat_obuch_k=kat_obuch.cod
	ORDER BY 3,5
