SELECT nazvanie_goroda, nazvanie_vuza 
	FROM vuz_gorod 
	WHERE cod_stran='01' 
	GROUP BY nazvanie_goroda, nazvanie_vuza