create Table RIO
(
Name  varchar(40) NOT NUll,
Designation varchar(40) NOT NUll,
Department_Name varchar(40) NOT NUll,
DOB DATETIME NOT NUll,
email varchar(50) NOT NUll UNIQUE,
Mobile DECIMAL(15) NOT NUll UNIQUE,
Reporting_Officer_Type int NOT NUll
);

INSERT INTO RIO (Name, Designation, Department_Name, DOB, email, Mobile, Reporting_Officer_Type)
	VALUES('Kamal', "jnrIT", "MOPA", "26-12-1992", "email1@gmail.com", "0192300000", 3),
			('Jamal', "jnrIT", "MOPA", "26-12-1990", "email2@gmail.com", "019230001", 3),
			('Alam', "jnrIT", "MOPA", "26-12-1994", "email3@gmail.com", "0192300002", 3);