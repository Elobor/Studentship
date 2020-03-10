SELECT fio, vuz.uch_zavedenie
	FROM poss, vuz
	WHERE gok='96'
	AND vuz_k=vuz.cod
	ORDER BY 2
