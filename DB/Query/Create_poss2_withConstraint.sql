CREATE TABLE poss2
	(nomer INTEGER 
		CHECK (nomer BETWEEN 1 AND 700000),
	fio CHAR (40) NOT NULL 
		CHECK (fio NOT LIKE '%.%' OR fio NOT LIKE '%-%'),
	d_rogd CHAR(2) 
		CHECK (d_rogd BETWEEN '01' AND '31'),
	m_rogd CHAR(2) 
		CHECK (m_rogd BETWEEN '01' AND '12'),
	g_rogd CHAR(2) 
		CHECK  (g_rogd between '00' AND '99'),
	pol CHAR(1) 
		CHECK (pol LIKE 'M' OR pol LIKE 'Æ'),
	sem_polog_k CHAR(1) 
		CHECK (sem_polog_k IN ('0', '1', '2', '3')),
	spec CHAR(6) 
		CHECK (spec BETWEEN '000000' AND '190046'),
	kat_obuch_k CHAR(2) 
		CHECK (kat_obuch_k BETWEEN '01' AND '17'),
	vuz_k INTEGER 
		CHECK (vuz_k BETWEEN 128955 AND 8199999),
	mp CHAR(2) 
		CHECK (mp BETWEEN '01' AND '12'),
	gp CHAR(2) 
		CHECK (gp BETWEEN '00' AND '99'),
	mo CHAR(2) 
		CHECK (mo BETWEEN '01' AND '12'),
	gok CHAR(2) 
		CHECK (gok BETWEEN '00' AND '99'),
	CONSTRAINT kat_obuch_const
		CHECK
			((kat_obuch_k IN ('01', '02') 
			AND
			(convert (integer, gok) - convert (integer, gp))=1) 
		OR
			(kat_obuch_k IN ('03', '04') 
			AND
			(convert (integer, gok) - convert (integer, gp)) IN (5, 6)) 
		OR
			(kat_obuch_k in ('05', '17') 
			AND
			(convert (integer, gok) - convert (integer, gp)) IN (4, 5)) 
		OR
			(kat_obuch_k='07' 
			AND 
			(convert (integer, gok) - convert (integer, gp))=3) 
		OR
			(kat_obuch_k='08' 
			AND 
			(convert(integer, gok) - convert (integer, gp))=4) 
		OR
			(kat_obuch_k in('10', '11') 
			AND
			(convert (integer, gok) - convert (integer, gp)) IN (1, 2)))) 
