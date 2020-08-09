
create procedure CRUD
@id int=0,@firstname varchar(50)=null,@middlename varchar(50)=null,@lastname varchar(50)=null,@sex varchar(1)=null,
@dob date=null,@phone int=null,@email varchar(50)=null,@department varchar(50)=null,@userPictureUrl varchar(50)=null,
@age int=null,@query int
AS
BEGIN
IF(@query=1)
BEGIN
INSERT INTO dbo.Profiles
(
	Id,FirstName,MiddleName,LastName,Sex,Dob,Phone,Email,Department,UserPicureUrl,Age
)
VALUES	
(
	@id,@firstname,@middlename,@lastname,@sex,@dob,@phone,@email,@department,@userPictureUrl,@age
)

IF(@@ROWCOUNT>0)
BEGIN
SELECT 'Insert'
END
END

IF(@query=2)
BEGIN
UPDATE dbo.Profiles
SET FirstName=@firstname,MiddleName=@lastname,Sex=@sex,Dob=@dob,Phone=@phone,Email=@email,Department=@department,UserPicureUrl=@userPictureUrl,
Age=@age
WHERE dbo.Profiles.Id=@id
SELECT 'Update'
END

IF(@query=3)
BEGIN
DELETE FROM dbo.Profiles WHERE Profiles.Id=@id
SELECT 'Delte'
END

IF (@query=4)
BEGIN
SELECT * FROM dbo.Profiles
END
END

IF(@query=5)
BEGIN
SELECT * FROM  dbo.Profiles WHERE Profiles.Id=@id
END


