DROP TABLE IF EXISTS Vault_Data;
GO

CREATE TABLE Vault_Data (
    ID INT PRIMARY KEY IDENTITY(1,1),
    PlatformName VARCHAR(255),
    Username VARCHAR(255),
    SavedPassword VARCHAR(MAX)
);
GO