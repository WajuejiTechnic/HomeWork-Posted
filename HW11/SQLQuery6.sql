USE [DemoShoppingCart]
GO

/****** Object:  StoredProcedure [dbo].[usp_Customer_Select]    Script Date: 2017/2/13 23:22:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Zhe Wang
-- Create date: 2/12/2017
-- Description:	Select Stored Procedure
-- =============================================
ALTER PROCEDURE [dbo].[usp_Customer_Select]
    @FirstName VARCHAR(25),
	@LastName VARCHAR(25),
	@Email VARCHAR(50),
	@UserName VARCHAR(25),
	@Password VARCHAR(25),
	@Phone VARCHAR(25)	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	    -- Select statements for procedure here
	SELECT FirstName, LastName, Email, UserName, Password, Phone, IsActive, CreatedDate
	FROM [dbo].[Customer]
		WHERE
	FirstName = @FirstName
	LastName = @LastName
	Email = @Email
	UserName = @UserName
	Password = @Password
	Phone = @Phone

	RETURN @@IDENTITY
END

GO


