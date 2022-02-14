SELECT NAME
FROM CREW
WHERE C_ID IN (SELECT C_ID
				FROM PART_OF_M
				WHERE M_ID IN (SELECT M_ID
						FROM BELONGS_TO_M
						WHERE NAME = 'Drama'));

//Drama filmleriyle ile uğraşan çalışanlar
								
SELECT TEXT_
FROM REVIEW
WHERE R_ID IN (SELECT R_ID
                FROM HAS_M
                WHERE M_ID IN (SELECT M_ID
                                FROM PART_OF_M
                                WHERE C_ID IN (SELECT C_ID
                                                FROM CREW
                                                WHERE NAME = 'Matthew McConaughey')));

//Matthew McConaughey'in içinde bulunduğu bir filmden yorum koy.

SELECT NAME
FROM CREW
WHERE C_ID IN (SELECT C_ID
                FROM CAST_
                WHERE AWARDS != 'NULL');

//Ödülü olan crew member'ları göster.
				
SELECT CREW.NAME, CAST_.GENDER, CREW.BIOGRAPHY
FROM CAST_
INNER JOIN CREW ON CREW.C_ID = CAST_.C_ID

//Oyuncuların ismini, cinsiyetini ve özet biografisini göster.

SELECT CREW.NAME,CAST_.GENDER
FROM CREW
INNER JOIN CAST_ ON CAST_.C_ID = CREW.C_ID 
WHERE CREW.C_ID IN (SELECT C_ID
					FROM PART_OF_M
					WHERE M_ID IN (SELECT M_ID
									FROM BELONGS_TO_M
									WHERE NAME = 'Drama'));

//Drama filmlerinde çalışan oyuncuları göster.
									
SELECT CREW.NAME,CAST_.GENDER,CREW.B_DATE,CREW.BIOGRAPHY
FROM CREW
INNER JOIN CAST_ ON CAST_.C_ID = CREW.C_ID 
WHERE CREW.C_ID IN (SELECT C_ID
					FROM PART_OF_M
					WHERE M_ID IN (SELECT M_ID
									FROM MOVIE
									WHERE TITLE = 'Interstellar'));

//Interstellar filminde oynayan oyuncuların ismini, cinsiyetini, doğum tarihini ve biografisini göster.
								
SELECT NAME FROM GENRE WHERE NAME IN (SELECT NAME
					FROM BELONGS_TO_M WHERE M_ID IN (SELECT M_ID
									FROM MOVIE WHERE TITLE = 'Interstellar'));

//Interstellar'ın genre'larını göster.
					
SELECT NAME FROM EPISODE_INCLUDES WHERE S_ID IN (SELECT S_ID
					FROM TVSERIES WHERE TITLE = 'Dracula');

//Dracula dizisinin bölüm isimlerini göster.
			
SELECT NAME FROM CREW WHERE C_ID IN (SELECT C_ID
					FROM PART_OF_S WHERE S_ID IN (SELECT S_ID
									FROM EPISODE_INCLUDES WHERE NAME = 'The Dark Compass'));

//Dracula'nın The Dark Compass bölümünde oynayan oyuncuları göster.

SELECT TEXT_ FROM REVIEW WHERE R_ID IN (SELECT R_ID
					FROM HAS_M WHERE M_ID IN (SELECT M_ID
									FROM BELONGS_TO_M WHERE NAME = 'Drama'));

//Drama filmlerine yazılmış reviewları göster.