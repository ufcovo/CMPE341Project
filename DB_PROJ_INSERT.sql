INSERT INTO MOVIE (M_ID,Budget,Runtime,Box_office,Title,Rate,Lang,Country,Year_) VALUES ('1','165000000','2.49','696300000','Interstellar','8.6','English','USA','2014');
INSERT INTO MOVIE (M_ID,Budget,Runtime,Box_office,Title,Rate,Lang,Country,Year_) VALUES ('2','4500000','1.42','7400000','Requiem for a Dream','8.3','English','USA','2000');
INSERT INTO MOVIE (M_ID,Budget,Runtime,Box_office,Title,Rate,Lang,Country,Year_) VALUES ('3','5000000','1.57','55700000','Dallas Buyers Club','8.0','English','USA','2013');
INSERT INTO MOVIE (M_ID,Budget,Runtime,Box_office,Title,Rate,Lang,Country,Year_) VALUES ('4',NULL,'2.33',NULL,'PK','8.1','Indian','India','2014');
-------------------------------------------------------------------------------------------------
INSERT INTO TVSERIES (S_ID,Budget,Season_no,Title,Rating,Lang,Country,Platform,Start_date,End_date) VALUES ('1',NULL,'1','Dracula','6.8','English','UK','Netflix',to_date('01/01/2020','DD/MM/RRRR'),to_date('01/01/2020','DD/MM/RRRR'));
INSERT INTO TVSERIES (S_ID,Budget,Season_no,Title,Rating,Lang,Country,Platform,Start_date,End_date) VALUES ('2',NULL,'1','Chernobyl','9.4','Russian','Russia','HBO',to_date('06/05/2019','DD/MM/RRRR'),to_date('03/06/2019','DD/MM/RRRR'));
-------------------------------------------------------------------------------------------------
INSERT INTO GENRE (NAME) VALUES ('Horror');
INSERT INTO GENRE (NAME) VALUES ('Drama');
INSERT INTO GENRE (NAME) VALUES ('Sci-fi');
INSERT INTO GENRE (NAME) VALUES ('Thriller');
INSERT INTO GENRE (NAME) VALUES ('Comedy');
INSERT INTO GENRE (NAME) VALUES ('Musical');
-------------------------------------------------------------------------------------------------
INSERT INTO REVIEW (R_ID,Date_,Nick,Rate,Text_) VALUES ('1',to_date('01/10/2019','DD/MM/RRRR'),'AhmadNeda','10','THIS IS A MANKIND ACHIEVEMENT. THE BEST MOVIE EVER MADE. IS ANYONE HAS DOUBT?');
INSERT INTO REVIEW (R_ID,Date_,Nick,Rate,Text_) VALUES ('2',to_date('03/01/2020','DD/MM/RRRR'),'svader','4','First two episodes were brilliant. Hour into the third and it is a mess. Another BBC drama let down by the final episode...');
INSERT INTO REVIEW (R_ID,Date_,Nick,Rate,Text_) VALUES ('3',to_date('27/08/2001','DD/MM/RRRR'),'j_mrf','10','Killer Performances by Ellen Burstyn... Darren Aronofsky: Stanley Kubrik has called for you to pull up a chair!');
INSERT INTO REVIEW (R_ID,Date_,Nick,Rate,Text_) VALUES ('4',to_date('20/11/2013','DD/MM/RRRR'),'Rebel_With_A_Cause_94','9','A Facisnating True Story with Gritty Realism and Excellent Performances');
-------------------------------------------------------------------------------------------------
INSERT INTO CREW (C_ID,Name,Nationality,B_date,Biography) VALUES ('1','Claes Bang','Denmark',to_date('28/04/1967','DD/MM/RRRR'),'Claes Kasper Bang is a Danish actor and musician. He is best known for playing the leading role of Christian in Ruben Östlunds 2017 film The Square.');
INSERT INTO CREW (C_ID,Name,Nationality,B_date,Biography) VALUES ('2','Christopher Nolan','UK',to_date('30/07/1970','DD/MM/RRRR'),'Best known for his cerebral, often nonlinear, storytelling, acclaimed writer-director Christopher Nolan was born on July 30, 1970, in London, England.');
INSERT INTO CREW (C_ID,Name,Nationality,B_date,Biography) VALUES ('3','Matthew McConaughey','USA',to_date('04/11/1969','DD/MM/RRRR'),'American actor and producer Matthew David McConaughey was born in Uvalde, Texas. His mother, Mary Kathleen (McCabe), is a substitute school teacher originally from New Jersey.');
INSERT INTO CREW (C_ID,Name,Nationality,B_date,Biography) VALUES ('4','Steven Moffat','UK',to_date('18/11/1961','DD/MM/RRRR'),'Steven Moffat was born on November 18, 1961 in Paisley, Scotland as Steven William Moffat. He is a writer and producer, known for Sherlock (2010)');
INSERT INTO CREW (C_ID,Name,Nationality,B_date,Biography) VALUES ('5','Hans Zimmer','Germany',to_date('12/09/1957','DD/MM/RRRR'),'German-born composer Hans Zimmer is recognized as one of Hollywoods most innovative musical talents.');
INSERT INTO CREW (C_ID,Name,Nationality,B_date,Biography) VALUES ('6','Ellen Burstyn','USA',to_date('07/12/1932','DD/MM/RRRR'),'Ellen Burstyn was born in Detroit, Michigan, to Correine Marie (Hamel) and John Austin Gillooly.');
INSERT INTO CREW (C_ID,Name,Nationality,B_date,Biography) VALUES ('7','Anne Hathaway','USA',to_date('12/11/1982','DD/MM/RRRR'),'Anne Jacqueline Hathaway was born in Brooklyn, New York, to Kate McCauley Hathaway, an actress, and Gerald T. Hathaway, a lawyer, both originally from Philadelphia.');
INSERT INTO CREW (C_ID,Name,Nationality,B_date,Biography) VALUES ('8','Dolly Wells','UK',to_date('05/12/1971','DD/MM/RRRR'),'Dolly Wells was born on December 5, 1971 in Merton, London, England as Dorothy Perpetua Gatacre.');
INSERT INTO CREW (C_ID,Name,Nationality,B_date,Biography) VALUES ('9','Jared Leto','USA',to_date('26/12/1971','DD/MM/RRRR'),'Jared Leto is a very familiar face in recent film history. Although he has always been the lead vocals, rhythm guitar, and songwriter for American band Thirty Seconds to Mars.');
INSERT INTO CREW (C_ID,Name,Nationality,B_date,Biography) VALUES ('10','Darren Aronofsky','USA',to_date('12/02/1969','DD/MM/RRRR'),'Darren Aronofsky was born February 12, 1969, in Brooklyn, New York. Growing up, Darren was always artistic: he loved classic movies and, as a teenager, he even spent time doing graffiti art.');
INSERT INTO CREW (C_ID,Name,Nationality,B_date,Biography) VALUES ('11','Melisa Wallack','USA',to_date('01/04/1968','DD/MM/RRRR'),NULL);
INSERT INTO CREW (C_ID,Name,Nationality,B_date,Biography) VALUES ('12','Jessie Buckley','Ireland',to_date('28/12/1989','DD/MM/RRRR'),NULL);
INSERT INTO CREW (C_ID,Name,Nationality,B_date,Biography) VALUES ('13','Aamir Khan','India',to_date('14/03/1965','DD/MM/RRRR'),'Aamir is doubtless one of the most dedicated actors in this world. With his recent successes in both the Indian and Chinese markets he has shouldered his way into becoming one of the worlds biggest superstars.');
INSERT INTO CREW (C_ID,Name,Nationality,B_date,Biography) VALUES ('14','Anushka Sharma','India',to_date('01/05/1988','DD/MM/RRRR'),NULL);
-------------------------------------------------------------------------------------------------
INSERT INTO EPISODE_INCLUDES (S_ID,E_NO,S_no,Name) VALUES ('1','1','1','The Rules of the Beast');
INSERT INTO EPISODE_INCLUDES (S_ID,E_NO,S_no,Name) VALUES ('1','2','1','Blood Vessel');
INSERT INTO EPISODE_INCLUDES (S_ID,E_NO,S_no,Name) VALUES ('1','3','1','The Dark Compass');
INSERT INTO EPISODE_INCLUDES (S_ID,E_NO,S_no,Name) VALUES ('2','1','1','1:23:45');
INSERT INTO EPISODE_INCLUDES (S_ID,E_NO,S_no,Name) VALUES ('2','2','1','Please Remain Calm');
INSERT INTO EPISODE_INCLUDES (S_ID,E_NO,S_no,Name) VALUES ('2','3','1','Open Wide, O Earth');
INSERT INTO EPISODE_INCLUDES (S_ID,E_NO,S_no,Name) VALUES ('2','4','1','The Happiness of All Mankind');
INSERT INTO EPISODE_INCLUDES (S_ID,E_NO,S_no,Name) VALUES ('2','5','1','Vichnaya Pamyat');
-------------------------------------------------------------------------------------------------
INSERT INTO WRITER (C_ID,TYPE_) VALUES ('4','Screen Writer');
INSERT INTO WRITER (C_ID,TYPE_) VALUES ('11','Screen Writer');
-------------------------------------------------------------------------------------------------
INSERT INTO CAST_ (C_ID,Pre_job,Gender,Awards) VALUES ('1',NULL,'Male',NULL);
INSERT INTO CAST_ (C_ID,Pre_job,Gender,Awards) VALUES ('3','Dallas Buyers Club','Male','Best Actor Oscar');
INSERT INTO CAST_ (C_ID,Pre_job,Gender,Awards) VALUES ('6','Requiem for a Dream','Female',NULL);
INSERT INTO CAST_ (C_ID,Pre_job,Gender,Awards) VALUES ('7','Passengers','Female',NULL);
INSERT INTO CAST_ (C_ID,Pre_job,Gender,Awards) VALUES ('8',NULL,'Female',NULL);
INSERT INTO CAST_ (C_ID,Pre_job,Gender,Awards) VALUES ('9','Dallas Buyers Club','Male','Best Supporting Actor Oscar');
INSERT INTO CAST_ (C_ID,Pre_job,Gender,Awards) VALUES ('12',NULL,'Female',NULL);
INSERT INTO CAST_ (C_ID,Pre_job,Gender,Awards) VALUES ('13',NULL,'Male',NULL);
INSERT INTO CAST_ (C_ID,Pre_job,Gender,Awards) VALUES ('14',NULL,'Female',NULL);
-------------------------------------------------------------------------------------------------
INSERT INTO DIRECTOR (C_ID,TYPE_) VALUES ('2','General');
INSERT INTO DIRECTOR (C_ID,TYPE_) VALUES ('10','General');
-------------------------------------------------------------------------------------------------
INSERT INTO PRODUCER (C_ID,Company) VALUES ('4','Tiger Aspect Productions');
-------------------------------------------------------------------------------------------------
INSERT INTO MUSICIAN (C_ID,Song) VALUES ('5','Main Theme');
-------------------------------------------------------------------------------------------------
INSERT INTO PART_OF_M (M_ID,C_ID) VALUES ('1','2');
INSERT INTO PART_OF_M (M_ID,C_ID) VALUES ('1','3');
INSERT INTO PART_OF_M (M_ID,C_ID) VALUES ('1','5');
INSERT INTO PART_OF_M (M_ID,C_ID) VALUES ('1','6');
INSERT INTO PART_OF_M (M_ID,C_ID) VALUES ('1','7');
INSERT INTO PART_OF_M (M_ID,C_ID) VALUES ('2','6');
INSERT INTO PART_OF_M (M_ID,C_ID) VALUES ('2','9');
INSERT INTO PART_OF_M (M_ID,C_ID) VALUES ('2','10');
INSERT INTO PART_OF_M (M_ID,C_ID) VALUES ('3','3');
INSERT INTO PART_OF_M (M_ID,C_ID) VALUES ('3','10');
INSERT INTO PART_OF_M (M_ID,C_ID) VALUES ('3','11');
INSERT INTO PART_OF_M (M_ID,C_ID) VALUES ('4','13');
INSERT INTO PART_OF_M (M_ID,C_ID) VALUES ('4','14');
-------------------------------------------------------------------------------------------------
INSERT INTO PART_OF_S (S_ID,C_ID) VALUES ('1','1');
INSERT INTO PART_OF_S (S_ID,C_ID) VALUES ('1','4');
INSERT INTO PART_OF_S (S_ID,C_ID) VALUES ('1','8');
INSERT INTO PART_OF_S (S_ID,C_ID) VALUES ('2','12');
-------------------------------------------------------------------------------------------------
INSERT INTO HAS_M (M_ID,R_ID) VALUES ('1','1');
INSERT INTO HAS_M (M_ID,R_ID) VALUES ('2','3');
INSERT INTO HAS_M (M_ID,R_ID) VALUES ('3','4');
-------------------------------------------------------------------------------------------------
INSERT INTO HAS_S (S_ID,R_ID) VALUES ('1','2');
-------------------------------------------------------------------------------------------------
INSERT INTO BELONGS_TO_M (M_ID,NAME) VALUES ('1','Drama');
INSERT INTO BELONGS_TO_M (M_ID,NAME) VALUES ('1','Sci-fi');
INSERT INTO BELONGS_TO_M (M_ID,NAME) VALUES ('2','Drama');
INSERT INTO BELONGS_TO_M (M_ID,NAME) VALUES ('3','Drama');
INSERT INTO BELONGS_TO_M (M_ID,NAME) VALUES ('4','Comedy');
INSERT INTO BELONGS_TO_M (M_ID,NAME) VALUES ('4','Musical');
-------------------------------------------------------------------------------------------------
INSERT INTO BELONGS_TO_S (S_ID,NAME) VALUES ('1','Horror');
INSERT INTO BELONGS_TO_S (S_ID,NAME) VALUES ('1','Sci-fi');
INSERT INTO BELONGS_TO_S (S_ID,NAME) VALUES ('2','Drama');
INSERT INTO BELONGS_TO_S (S_ID,NAME) VALUES ('2','Thriller');