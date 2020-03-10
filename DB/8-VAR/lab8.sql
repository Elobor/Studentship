CREATE PROCEDURE zaprForLab8
	AS
	DECLARE @godpr CHAR (2)			/* ���������� ��� ���� ����� */
	DECLARE @speciality CHAR (6)		/*���������� ��� �������� �������������*/
	DECLARE @speciality_it INT			/* ���������� ��� ����� �� �������������*/
	DECLARE @godpr_it INT			/* ���������� ��� ����� ���� ����� */
	DECLARE @final_it INT			/* ���������� ��� ����� �� ����� ������� */
	DECLARE @godpr_last CHAR (2)	/*���������� ��� �������� ���� �����*/

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
			PRINT '������ ��� ���������� ������� FETCH'
			CLOSE i_dunno_how_it_works /* �������� ������� � ������� ��������� � ������ ������ */
			RETURN
		END
		IF (@@fetch_status=-1) 
		BEGIN
			PRINT '������ �� �������'
			CLOSE i_dunno_how_it_works /*�������� ������� � ������� ��������� � ������ ���������� ������ �� ������� */
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
				PRINT '������ ��� ���������� FETCH'
				RETURN /* ������� ��������� � ������ ������ */
			END
	PRINT '����� �� ������� - '+str(@final_it)
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
			PRINT '������ ��� ���������� ������� FETCH'
			CLOSE kinda_know_how_it_works /* �������� ������� � ������� ��������� � ������ ������ */
			RETURN
		END
		IF (@@fetch_status=-1) 
		BEGIN
			PRINT '������ �� �������'
			CLOSE kinda_know_how_it_works /*�������� ������� � ������� ��������� � ������ ���������� ������ �� ������� */
			RETURN 
		END
		SELECT @godpr_last = @godpr
		PRINT '������������� '+@speciality+' - '+str(@speciality_it)
		SELECT @godpr_it=@godpr_it+@speciality_it
		SELECT @final_it=@final_it+@speciality_it
		WHILE (@@fetch_status=0)
			BEGIN
				FETCH kinda_know_how_it_works INTO @godpr, @speciality, @speciality_it
				IF (@godpr_last !=@godpr) 
					BEGIN
						PRINT '����� ������� ��� '+ @godpr_last +' ���� �����  - ' +str(@godpr_it)
						SELECT @godpr_last=@godpr
						SELECT @godpr_it=0
					END 
				IF (@@fetch_status=-1) 
					BREAK
				PRINT '������������� '+@speciality + ' - ' +str(@speciality_it)
				SELECT @godpr_it=@godpr_it+@speciality_it
				SELECT @final_it=@final_it+@speciality_it /* ������� ������ ����� �� ������� */
			END
		CLOSE kinda_know_how_it_works
		IF (@@fetch_status=-2) 
		BEGIN
			PRINT '������ ��� ���������� FETCH'
			RETURN /* ������� ��������� � ������ ������ */
		END
		PRINT '����� ������� ��� '+ @godpr_last +' ���� �����  - ' +str(@godpr_it)
DEALLOCATE kinda_know_how_it_works
RETURN