CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS houses(
        id int NOT NULL AUTO_INCREMENT PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        name char(255) NOT NULL,
        sqft int NOT NULL,
        bedrooms int NOT NULL,
        bathrooms INT NOT NULL,
        description varchar(500) NOT NULL,
        price INT NOT NULL
    )

SELECT * FROM houses;

INSERT INTO
    houses (
        name,
        sqft,
        bedrooms,
        bathrooms,
        description,
        price
    )
VALUES (
        'Cute Home',
        400,
        4,
        2,
        'A lovely little home that is totally not here to test you',
        100
    );