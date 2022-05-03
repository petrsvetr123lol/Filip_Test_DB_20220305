﻿CREATE TABLE [dbo].[Faktury] (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [datum]     DATE          NOT NULL,
    [cislo]     INT           NOT NULL,
    [odberatel] NVARCHAR (50) NOT NULL,
    [nazev]     NVARCHAR (20) NOT NULL,
    [pocet]     INT           NOT NULL,
    [cena]      FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

INSERT INTO dbo.Faktury VALUES ('01/01/2003', 15, 'Gatema', 'Plech', 50, 700)