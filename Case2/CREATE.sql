CREATE TABLE PRODUCT
(
"Id" INTEGER PRIMARY KEY,
"Name" TEXT NOT NULL
)

CREATE TABLE CATEGORY
(
"Id" INTEGER PRIMARY KEY,
"Name" TEXT NOT NULL
)

CREATE TABLE PRODUCT_CATEGORY
(
ProductId INTEGER NOT NULL,
CategoryId INTEGER,
FOREIGN KEY (ProductId) REFERENCES PRODUCT(Id),
FOREIGN KEY (CategoryId) REFERENCES CATEGORY(Id)
)