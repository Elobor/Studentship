CREATE TRIGGER vuz_spec 
	ON poss1
	FOR INSERT 
	AS
		IF (SELECT COUNT(*) FROM codv, inserted
		WHERE codv.vkod=inserted.vuz_k)=0
		SELECT '�������� ���� vuz_k �� ����������� ������'
		IF (SELECT COUNT(*) FROM cods, inserted
		WHERE cods.skod=inserted.spec)=0
		SELECT '�������� ���� spec �� ����������� ������'
