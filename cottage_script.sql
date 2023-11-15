BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Areas" (
	"AreaId"	INTEGER NOT NULL,
	"Name"	TEXT,
	CONSTRAINT "PK_Areas" PRIMARY KEY("AreaId" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Posts" (
	"PostalCode"	TEXT NOT NULL,
	"PostOffice"	TEXT,
	CONSTRAINT "PK_Posts" PRIMARY KEY("PostalCode")
);
CREATE TABLE IF NOT EXISTS "Services" (
	"ServiceId"	INTEGER NOT NULL,
	"AreaId"	INTEGER NOT NULL,
	"Name"	TEXT,
	"Type"	INTEGER,
	"Description"	TEXT,
	"Price"	REAL NOT NULL,
	"Vat"	REAL NOT NULL,
	CONSTRAINT "PK_Services" PRIMARY KEY("ServiceId" AUTOINCREMENT),
	CONSTRAINT "FK_Services_Areas_AreaId" FOREIGN KEY("AreaId") REFERENCES "Areas"("AreaId") ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS "Cottages" (
	"CottageId"	INTEGER NOT NULL,
	"AreaId"	INTEGER NOT NULL,
	"PostalCode"	TEXT NOT NULL,
	"CottageName"	TEXT,
	"Address"	TEXT,
	"Price"	REAL NOT NULL,
	"Description"	TEXT,
	"AmountOfPeople"	INTEGER,
	"Amenities"	TEXT,
	"PostalCodeNavigationPostalCode"	TEXT NOT NULL,
	CONSTRAINT "PK_Cottages" PRIMARY KEY("CottageId" AUTOINCREMENT),
	CONSTRAINT "FK_Cottages_Areas_AreaId" FOREIGN KEY("AreaId") REFERENCES "Areas"("AreaId") ON DELETE CASCADE,
	CONSTRAINT "FK_Cottages_Posts_PostalCodeNavigationPostalCode" FOREIGN KEY("PostalCodeNavigationPostalCode") REFERENCES "Posts"("PostalCode") ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS "Customers" (
	"CustomerId"	INTEGER NOT NULL,
	"PostalCode"	TEXT NOT NULL,
	"FirstName"	TEXT,
	"LastName"	TEXT,
	"Address"	TEXT,
	"Email"	TEXT,
	"Phonenumber"	TEXT,
	"PostalCodeNavigationPostalCode"	TEXT NOT NULL,
	CONSTRAINT "PK_Customers" PRIMARY KEY("CustomerId" AUTOINCREMENT),
	CONSTRAINT "FK_Customers_Posts_PostalCodeNavigationPostalCode" FOREIGN KEY("PostalCodeNavigationPostalCode") REFERENCES "Posts"("PostalCode") ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS "Reservations" (
	"ReservationId"	INTEGER NOT NULL,
	"CustomerId"	INTEGER NOT NULL,
	"CottageId"	INTEGER NOT NULL,
	"ReservedDate"	TEXT NOT NULL,
	"ConfirmationDate"	TEXT NOT NULL,
	"ReservedStartDate"	TEXT NOT NULL,
	"ReservedEndDate"	TEXT NOT NULL,
	CONSTRAINT "FK_Reservations_Customers_CustomerId" FOREIGN KEY("CustomerId") REFERENCES "Customers"("CustomerId") ON DELETE CASCADE,
	CONSTRAINT "FK_Reservations_Cottages_CottageId" FOREIGN KEY("CottageId") REFERENCES "Cottages"("CottageId") ON DELETE CASCADE,
	CONSTRAINT "PK_Reservations" PRIMARY KEY("ReservationId" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Invoices" (
	"InvoiceId"	INTEGER NOT NULL,
	"ReservationId"	INTEGER NOT NULL,
	"Sum"	REAL NOT NULL,
	"Vat"	REAL NOT NULL,
	CONSTRAINT "FK_Invoices_Reservations_ReservationId" FOREIGN KEY("ReservationId") REFERENCES "Reservations"("ReservationId") ON DELETE CASCADE,
	CONSTRAINT "PK_Invoices" PRIMARY KEY("InvoiceId" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "ReservationServices" (
	"ReservationId"	INTEGER NOT NULL,
	"ServiceId"	INTEGER NOT NULL,
	"Amount"	INTEGER NOT NULL,
	CONSTRAINT "FK_ReservationServices_Reservations_ReservationId" FOREIGN KEY("ReservationId") REFERENCES "Reservations"("ReservationId") ON DELETE CASCADE,
	CONSTRAINT "FK_ReservationServices_Services_ServiceId" FOREIGN KEY("ServiceId") REFERENCES "Services"("ServiceId") ON DELETE CASCADE,
	CONSTRAINT "PK_ReservationServices" PRIMARY KEY("ReservationId","ServiceId")
);
INSERT INTO "Posts" ("PostalCode","PostOffice") VALUES ('70800','Kuopio');
CREATE INDEX IF NOT EXISTS "IX_Cottages_AreaId" ON "Cottages" (
	"AreaId"
);
CREATE INDEX IF NOT EXISTS "IX_Cottages_PostalCodeNavigationPostalCode" ON "Cottages" (
	"PostalCodeNavigationPostalCode"
);
CREATE INDEX IF NOT EXISTS "IX_Customers_PostalCodeNavigationPostalCode" ON "Customers" (
	"PostalCodeNavigationPostalCode"
);
CREATE INDEX IF NOT EXISTS "IX_Invoices_ReservationId" ON "Invoices" (
	"ReservationId"
);
CREATE INDEX IF NOT EXISTS "IX_Reservations_CottageId" ON "Reservations" (
	"CottageId"
);
CREATE INDEX IF NOT EXISTS "IX_Reservations_CustomerId" ON "Reservations" (
	"CustomerId"
);
CREATE INDEX IF NOT EXISTS "IX_ReservationServices_ServiceId" ON "ReservationServices" (
	"ServiceId"
);
CREATE INDEX IF NOT EXISTS "IX_Services_AreaId" ON "Services" (
	"AreaId"
);
COMMIT;
