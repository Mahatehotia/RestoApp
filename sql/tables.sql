DROP TABLE IF EXISTS commandes;
DROP TABLE IF EXISTS paniers;
DROP TABLE IF EXISTS consommations;
DROP TABLE IF EXISTS types;
DROP TABLE IF EXISTS regimes;
DROP TABLE IF EXISTS tables;
DROP TABLE IF EXISTS clients;

#------------------------------------------------------------
# Table: clients
#------------------------------------------------------------

CREATE TABLE clients(
	idClient int(10) PRIMARY KEY AUTO_INCREMENT NOT NULL,
	nomClient varchar(255) NOT NULL
)ENGINE=InnoDB DEFAULT CHARSET=utf8;

#------------------------------------------------------------
# Table: tables
#------------------------------------------------------------

CREATE TABLE tables(
	idTable int(10) PRIMARY KEY AUTO_INCREMENT NOT NULL,
	numTable int(10) NOT NULL
)ENGINE=InnoDB DEFAULT CHARSET=utf8;

#------------------------------------------------------------
# Table: Régimes alimentaire
#------------------------------------------------------------
CREATE TABLE regimes(
	idRegime int(10) AUTO_INCREMENT NOT NULL,
	nomRegime varchar(255) NOT NULL,
	PRIMARY KEY (idRegime)
)ENGINE=InnoDB DEFAULT CHARSET=utf8;

#------------------------------------------------------------
# Table: types de consommation
#------------------------------------------------------------

CREATE TABLE types(
	idType int(10) AUTO_INCREMENT NOT NULL,
	nomType varchar(255) NOT NULL,
	id_Regime int(10),
	PRIMARY KEY (idType),
	FOREIGN KEY (id_Regime) REFERENCES regimes(idRegime) ON DELETE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=utf8;

#------------------------------------------------------------
# Table: consommations
#------------------------------------------------------------

CREATE TABLE consommations(
	idConso int(10) AUTO_INCREMENT NOT NULL,
	nomConso varchar(255) NOT NULL,
	prixConso float(10) NOT NULL,
	detailConso varchar(255) NOT NULL,
	id_type int(10) NOT NULL,
	PRIMARY KEY (idConso),
	FOREIGN KEY (id_type) REFERENCES types(idType) ON DELETE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=utf8;

#------------------------------------------------------------
# Table: paniers
#------------------------------------------------------------

CREATE TABLE paniers(
	idPanier int(10) AUTO_INCREMENT NOT NULL,
	quantite int(10) NOT NULL,
	id_conso int(10) NOT NULL,
	PRIMARY KEY (idPanier, id_Conso),
	FOREIGN KEY (id_Conso) REFERENCES consommations(idConso) ON DELETE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=utf8;

#------------------------------------------------------------
# Table: commandes
#------------------------------------------------------------

CREATE TABLE commandes(
	idCommande int(10) AUTO_INCREMENT NOT NULL,
	nomCommande varchar(255) NOT NULL,
	coutCommande Float(10) NOT NULL,
	etatCommande enum('annulé','payé','en cours'),
	id_panier int(10) NOT NULL,
	id_client int(10) NOT NULL,
	id_table int(10) NOT NULL,
	PRIMARY KEY (idCommande),
	FOREIGN KEY (id_client) REFERENCES clients(idClient) ON DELETE CASCADE,
	FOREIGN KEY (id_panier) REFERENCES paniers(idPanier) ON DELETE CASCADE,
	FOREIGN KEY (id_table) REFERENCES tables(idTable) ON DELETE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=utf8;