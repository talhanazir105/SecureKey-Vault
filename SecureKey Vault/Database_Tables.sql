-- App_User Table (Master Key save karne ke liye)
CREATE TABLE App_User (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Master_Key VARCHAR(255) NOT NULL
);

-- Ek default password 'Admin123' daal dete hain taake baad me login kar sakein
INSERT INTO App_User (Master_Key) VALUES ('Admin123');

-- Vault_Data Table (Passwords save karne ke liye)
CREATE TABLE Vault_Data (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    PlatformName VARCHAR(255) NOT NULL,
    Username VARCHAR(255) NOT NULL,
    SavedPassword VARCHAR(MAX) NOT NULL 
);