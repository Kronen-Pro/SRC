CREATE TABLE [dbo].[DemographForm]
(
	[datedTime] DATETIME NOT NULL PRIMARY KEY, 
    [RoomId] INT NOT NULL, 
    [UserAccount] INT NOT NULL, 
    [UserTime] DATETIME NOT NULL, 
    [Male] INT NOT NULL, 
    [Female] INT NOT NULL, 
    [Caucasian] INT NOT NULL, 
    [AfricanAmerican] INT NOT NULL, 
    [Other] INT NOT NULL, 
    CONSTRAINT [FK_DemographForm_Room] FOREIGN KEY (RoomId) REFERENCES Room(RoomId)
)
