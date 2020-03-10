CREATE PROCEDURE zaprForLab8
	AS
	DECLARE @godpr CHAR (2)			/* переменная для года приёма */
	DECLARE @speciality CHAR (6)		/*переменная для названия специальности*/
	DECLARE @speciality_it INT			/* переменная для итога по специальности*/
	DECLARE @godpr_it INT			/* переменная для итога году приёма */
	DECLARE @final_it INT			/* переменная для итога по всему запросу */
	DECLARE @godpr_last CHAR (2)	/*переменная для прошлого года приёма*/

DECLARE i_dunno_how_it_works CURSOR FOR
	SELECT gp, spec, COUNT(*)
		FROM ukr
	GROUP BY spec, gp
	ORDER BY gp
	SELECT @godpr_it = 0
	SELECT @final_it = 0
	OPEN i_dunno_how_it_works
		FETCH i_dunno_how_it_works INTO @godpr, @speciality, @speciality_it
		IF (@@fetch_status=-2) 
		BEGIN
			PRINT 'Ошибка при выполнении первого FETCH'
			CLOSE i_dunno_how_it_works /* закрытие курсора и останов процедуры в случае ошибки */
			RETURN
		END
		IF (@@fetch_status=-1) 
		BEGIN
			PRINT 'Данные не найдены'
			CLOSE i_dunno_how_it_works /*закрытие курсора и останов процедуры в случае отсутствия данных по запросу */
			RETURN 
		END
		SELECT @godpr_last = @godpr
		SELECT @godpr_it=@godpr_it+@speciality_it
		SELECT @final_it=@final_it+@speciality_it	
		WHILE (@@fetch_status=0)
			BEGIN
				FETCH i_dunno_how_it_works INTO @godpr, @speciality, @speciality_it
				IF (@@fetch_status=-1) 
					BREAK
				SELECT @final_it=@final_it+@speciality_it
			END
		CLOSE i_dunno_how_it_works
	IF (@@fetch_status=-2) 
			BEGIN
				PRINT 'Ошибка при выполнении FETCH'
				RETURN /* останов процедуры в случае ошибки */
			END
	PRINT 'всего по запросу - '+str(@final_it)
	PRINT '---------------------------------'
DEALLOCATE i_dunno_how_it_works
	
DECLARE kinda_know_how_it_works CURSOR FOR
	SELECT gp, spec, COUNT(*)
		FROM ukr
	GROUP BY spec, gp
	ORDER BY gp
	SELECT @godpr_it = 0
	SELECT @final_it = 0
	OPEN kinda_know_how_it_works
		FETCH kinda_know_how_it_works INTO @godpr, @speciality, @speciality_it
		IF (@@fetch_status=-2) 
		BEGIN
			PRINT 'Ошибка при выполнении первого FETCH'
			CLOSE kinda_know_how_it_works /* закрытие курсора и останов процедуры в случае ошибки */
			RETURN
		END
		IF (@@fetch_status=-1) 
		BEGIN
			PRINT 'Данные не найдены'
			CLOSE kinda_know_how_it_works /*закрытие курсора и останов процедуры в случае отсутствия данных по запросу */
			RETURN 
		END
		SELECT @godpr_last = @godpr
		PRINT 'Специальность '+@speciality+' - '+str(@speciality_it)
		SELECT @godpr_it=@godpr_it+@speciality_it
		SELECT @final_it=@final_it+@speciality_it
		WHILE (@@fetch_status=0)
			BEGIN
				FETCH kinda_know_how_it_works INTO @godpr, @speciality, @speciality_it
				IF (@godpr_last !=@godpr) 
					BEGIN
						PRINT 'Всего записей для '+ @godpr_last +' года приёма  - ' +str(@godpr_it)
						SELECT @godpr_last=@godpr
						SELECT @godpr_it=0
					END 
				IF (@@fetch_status=-1) 
					BREAK
				PRINT 'Специальность '+@speciality + ' - ' +str(@speciality_it)
				SELECT @godpr_it=@godpr_it+@speciality_it
				SELECT @final_it=@final_it+@speciality_it /* подсчет общего итога по запросу */
			END
		CLOSE kinda_know_how_it_works
		IF (@@fetch_status=-2) 
		BEGIN
			PRINT 'Ошибка при выполнении FETCH'
			RETURN /* останов процедуры в случае ошибки */
		END
		PRINT 'Всего записей для '+ @godpr_last +' года приёма  - ' +str(@godpr_it)
DEALLOCATE kinda_know_how_it_works
RETURN