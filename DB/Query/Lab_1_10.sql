SELECT nomer 
	FROM poss 
	GROUP BY nomer 
	HAVING count(*)>1