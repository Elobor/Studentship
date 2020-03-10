SELECT * 
	FROM Student.dbo.poss 
	WHERE gok IN ('95', '97', '98') 
	
	UNION

SELECT * 
	FROM Student.dbo.ukr 
	WHERE gok IN ('95', '97', '98')
