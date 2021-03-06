

CREATE proc [dbo].[ArticleAddOrEdit]
@ArticleID int,
@DocumentID int,
@ArticleName varchar(100),
@Quantity int,
@NetPrice decimal(18,2),
@GrossPrice decimal(18,2)

as 
--insert
	IF @ArticleID=0
	Insert into Articles(DocumentID,ArticleName,Quantity,NetPrice,GrossPrice)
	Values(@DocumentID,@ArticleName,@Quantity,@NetPrice,@GrossPrice)
	else
--update
update Articles
set
DocumentID=@DocumentID,
ArticleName=@ArticleName,
Quantity=@Quantity,
NetPrice=@NetPrice,
GrossPrice=@GrossPrice
where ArticleID=@ArticleID
GO

CREATE proc [dbo].[ArticleDelete]
@ArticleID int


as 
delete from Articles
where ArticleID=@ArticleID
GO

create proc [dbo].[CreateNewCustomer]
@CustomerName varchar(100)
as

Insert into Customers(CustomerName) values(@customerName)
GO


CREATE PROC [dbo].[DocumentAddOrEdit]
@DocumentID int,
@DocumentDate date,
@CustomerNumber int,
@CustomerName varchar(100)
AS

--INSERT

if @DocumentID= 0 BEGIN
insert into Documents(DocumentDate,CustomerNumber) values(@DocumentDate,@CustomerNumber)
select SCOPE_IDENTITY();
insert into Customers(CustomerNumber,CustomerName) values(@CustomerNumber,@CustomerName)
END

--UPDATE
Else BEGIN	
Update Documents
set
DocumentDate=@DocumentDate,
CustomerNumber=@CustomerNumber
where DocumentID=@DocumentID

select @DocumentID;

Update Customers
set
CustomerName=@CustomerName
where CustomerNumber=@CustomerNumber

end











GO


CREATE PROC [dbo].[DocumentDelete]
@DocumentID int

AS

--INSERT
--master
delete from Documents where DocumentID=@DocumentID
--details

delete from Articles where  DocumentID=@DocumentID
GO
/****** Object:  StoredProcedure [dbo].[DocumentViewAll]    Script Date: 03.05.2020 22:13:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[DocumentViewAll]
AS
select doc.documentID,
doc.DocumentDate,
cus.CustomerNumber,
cus.customerName,
(select sum(quantity*netprice) from Articles as art where art.DocumentID=doc.DocumentID)as TotalNet,
(select sum(quantity*GrossPrice) from Articles as art where art.DocumentID=doc.DocumentID)as TotalGross	
from
Documents doc inner join 
Customers cus on 
doc.CustomerNumber=cus.CustomerNumber
GO



CREATE PROC [dbo].[DocumentViewByID]
@DocumentID int

AS
select doc.documentID,
doc.DocumentDate,
cus.CustomerNumber,
cus.customerName,
(select sum(quantity*netprice) from Articles as art where art.DocumentID=doc.DocumentID)as TotalNet,
(select sum(quantity*netprice) from Articles as art where art.DocumentID=doc.DocumentID)as TotalGross	
from
Documents doc inner join 
Customers cus on 
doc.CustomerNumber=cus.CustomerNumber
where doc.documentid=@DocumentID


select *
from Articles 
where DocumentID=@DocumentID;
GO
