CREATE TRIGGER vuzTrig1 
	ON vuz
	FOR INSERT, UPDATE, DELETE
	AS
		SELECT '���������� ������ ��������������� ��������� � ������� vuz_gorod'