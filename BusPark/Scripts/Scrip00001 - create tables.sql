create table Repair
(
[RepairId] uniqueidentifier not null primary key,
[InRepair] bit 
)
create table Buses
(
[BusId] uniqueidentifier not null primary key,
[Number] nvarchar(max) null,
[Price] int not null
FOREIGN KEY (RepairId) REFERENCES Repair(RepairId)
)
create table Mechanices
(
[MechanicId] uniqueidentifier not null primary key,
[FullName] nvarchar(max) null,
[WorkExperience] nvarchar(max) null
FOREIGN KEY (BusId) REFERENCES Buses(BusId)
)
