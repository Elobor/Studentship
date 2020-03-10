CREATE TABLE poss3
	(nomer INTEGER ,
	fio CHAR (40) NOT NULL ,
	d_rogd CHAR(2) ,
	m_rogd CHAR(2) ,
	g_rogd CHAR(2) ,
	pol CHAR(1) ,
	sem_polog_k CHAR(1) ,
	spec CHAR(6) ,
	kat_obuch_k CHAR(2) ,
	vuz_k INTEGER ,
	mp CHAR(2) ,
	gp CHAR(2) ,
	mo CHAR(2) ,
	gok CHAR(2) ,
	CONSTRAINT god_con
		CHECK
			(g_rogd < gp
			AND
			gp < gok),
	CONSTRAINT kat_obuch_con
		CHECK
				((kat_obuch_k IN ('07', '08', '09')
				AND
				spec NOT LIKE ('00____'))
			OR
				(kat_obuch_k NOT IN ('07', '08', '09')
				AND
				spec LIKE ('00____'))),
	CONSTRAINT pol_con
		CHECK
				((pol = 'Æ'
				AND
				fio LIKE '%à % %')
			OR
				(pol = 'Ì'
				AND
				fio NOT LIKE '%à % %'))
	)