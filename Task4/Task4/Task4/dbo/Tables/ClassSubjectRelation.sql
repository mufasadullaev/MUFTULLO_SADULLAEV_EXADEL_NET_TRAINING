CREATE TABLE [dbo].[ClassSubjectRelation]
(
    [ClassId] INT NOT NULL, 
    [SubjectId] INT NOT NULL
    FOREIGN KEY (ClassId) REFERENCES Class(Id),
    FOREIGN KEY (SubjectId) REFERENCES Subject(Id),
    UNIQUE (ClassId, SubjectId)
);
