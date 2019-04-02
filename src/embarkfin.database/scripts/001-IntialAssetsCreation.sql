CREATE TABLE [Location] (
  [ID] integer,
  [longitude] integer,
  [latitude] integer,
  [Date] Date,
  PRIMARY KEY ([ID])
);

CREATE TABLE [Asset_Type] (
  [ID] integer,
  [Name] nvarchar(100),
  PRIMARY KEY ([ID])
);

CREATE TABLE [Asset] (
  [ID] integer,
  [Serial_Number] nvarchar(100),
  [Date_Purchased] Date,
  [Period] integer,
  [Purchase_Price] money,
  [QRCode] binary,
  [Disposal_ID] Integer null,
  [Location_ID] Integer,
  [Asset_Type_ID] Integer,
  PRIMARY KEY ([ID])
);

CREATE TABLE [Trial_Balance] (
  [ID] integer,
  [Debit] float,
  [Credit] float,
  PRIMARY KEY ([ID])
);

CREATE TABLE [Disposal] (
  [ID] Integer,
  [Asset_Id] Integer,
  [Disposed_Date] Date,
  [Disposal_Price] float,
  PRIMARY KEY ([ID])
);



