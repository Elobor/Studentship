SELECT COUNT(*) 
	FROM poss 
	WHERE gp='90'

SELECT vuz.uch_zavedenie, COUNT(*)
	FROM poss, vuz
	WHERE gp='90' and vuz_k=vuz.cod
	GROUP BY vuz.uch_zavedenie

SELECT vuz.uch_zavedenie, kat_obuch.kat_obucheniya, COUNT(*)
	FROM poss, vuz, kat_obuch
	WHERE gp='90' 
		AND vuz_k=vuz.cod
		AND kat_obuch_k=kat_obuch.cod
	GROUP BY vuz.uch_zavedenie, kat_obuch.kat_obucheniya

