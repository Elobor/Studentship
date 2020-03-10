SELECT COUNT(*)
	FROM poss
	WHERE gok = 96

SELECT vuz.uch_zavedenie, COUNT (*)
	FROM poss
		JOIN vuz ON vuz_k=vuz.cod
	WHERE gok = 96
	GROUP BY vuz.uch_zavedenie