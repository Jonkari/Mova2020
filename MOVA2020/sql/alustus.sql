-- -----------------------------------------------------
-- Table posti
-- -----------------------------------------------------

CREATE TABLE posti (
  postinro CHAR(5) NOT NULL,
  toimipaikka VARCHAR(45) NULL,
  PRIMARY KEY (postinro)
  );


-- -----------------------------------------------------
-- Table asiakas
-- -----------------------------------------------------
CREATE TABLE asiakas (
  asiakas_id INTEGER NOT NULL,
  postinro CHAR(5) NOT NULL,
  etunimi VARCHAR(20) NULL DEFAULT NULL,
  sukunimi VARCHAR(40) NULL DEFAULT NULL,
  lahiosoite VARCHAR(40) NULL DEFAULT NULL,
  email VARCHAR(50) NULL DEFAULT NULL,
  puhelinnro VARCHAR(15) NULL DEFAULT NULL,
  PRIMARY KEY (asiakas_id),
  CONSTRAINT fk_asiakas_posti FOREIGN KEY (postinro) REFERENCES posti (postinro) ON DELETE NO ACTION ON UPDATE NO ACTION
);


-- -----------------------------------------------------
-- Table toimintaalue
-- -----------------------------------------------------
CREATE TABLE toimintaalue (
  toimintaalue_id INTEGER  NOT NULL ,
  nimi VARCHAR(40) NULL DEFAULT NULL,
  PRIMARY KEY (toimintaalue_id)
);



-- -----------------------------------------------------
-- Table mokki
-- -----------------------------------------------------
CREATE TABLE mokki (
  mokki_id INTEGER NOT NULL,
  toimintaalue_id INT(11) NOT NULL,
  postinro CHAR(5) NOT NULL,
  mokkinimi VARCHAR(45) NULL,
  hinta DOUBLE(8, 2) NOT NULL,
  katuosoite VARCHAR(45) NULL,
  kuvaus VARCHAR(150) NULL,
  henkilomaara INT NULL,
  varustelu VARCHAR(100) NULL,
  PRIMARY KEY (mokki_id),
  CONSTRAINT fk_mokki_toimintaalue FOREIGN KEY (toimintaalue_id) REFERENCES toimintaalue (toimintaalue_id) ON DELETE RESTRICT ON UPDATE NO ACTION,
  CONSTRAINT fk_mokki_posti FOREIGN KEY (postinro) REFERENCES posti (postinro) ON DELETE NO ACTION ON UPDATE NO ACTION
);



-- -----------------------------------------------------
-- Table varaus
-- -----------------------------------------------------
CREATE TABLE varaus (
  varaus_id INTEGER NOT NULL,
  asiakas_id INT(11) NOT NULL,
  mokki_mokki_id INT NOT NULL,
  varattu_pvm DATETIME NULL DEFAULT NULL,
  vahvistus_pvm DATETIME NULL DEFAULT NULL,
  varattu_alkupvm DATETIME NULL DEFAULT NULL,
  varattu_loppupvm DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (varaus_id),
  CONSTRAINT varaus_ibfk FOREIGN KEY (asiakas_id) REFERENCES asiakas (asiakas_id) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT fk_varaus_mokki FOREIGN KEY (mokki_mokki_id) REFERENCES mokki (mokki_id) ON DELETE NO ACTION ON UPDATE NO ACTION
);





-- -----------------------------------------------------
-- Table lasku
-- -----------------------------------------------------
CREATE TABLE lasku (
  lasku_id INTEGER NOT NULL,
  varaus_id INT(11) NOT NULL,
  summa DOUBLE(8, 2) NOT NULL,
  alv DOUBLE(8, 2) NOT NULL,
  PRIMARY KEY (lasku_id),
  CONSTRAINT lasku_ibfk_1 FOREIGN KEY (varaus_id) REFERENCES varaus (varaus_id) ON DELETE CASCADE
);





-- -----------------------------------------------------
-- Table palvelu
-- -----------------------------------------------------
CREATE TABLE palvelu (
  palvelu_id INTEGER NOT NULL,
  toimintaalue_id INT(11) NOT NULL,
  nimi VARCHAR(40) NULL DEFAULT NULL,
  tyyppi INT(11) NULL DEFAULT NULL,
  kuvaus VARCHAR(255) NULL DEFAULT NULL,
  hinta DOUBLE(8, 2) NOT NULL,
  alv DOUBLE(8, 2) NOT NULL,
  PRIMARY KEY (palvelu_id),
  CONSTRAINT palvelu_ibfk_1 FOREIGN KEY (toimintaalue_id) REFERENCES toimintaalue (toimintaalue_id) ON DELETE RESTRICT ON UPDATE NO ACTION
);





-- -----------------------------------------------------
-- Table varauksen_palvelut
-- -----------------------------------------------------
CREATE TABLE varauksen_palvelut (
  varaus_id INTEGER NOT NULL,
  palvelu_id INT(11) NOT NULL,
  lkm INT(11) NOT NULL,
  PRIMARY KEY (palvelu_id, varaus_id),
  CONSTRAINT fk_varaus FOREIGN KEY (varaus_id) REFERENCES varaus (varaus_id) ON DELETE CASCADE,
  CONSTRAINT fk_palvelu FOREIGN KEY (palvelu_id) REFERENCES palvelu (palvelu_id) ON DELETE RESTRICT ON UPDATE RESTRICT
);


