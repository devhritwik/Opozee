USE [oposeeDb]
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteBountyQuestion]    Script Date: 24-May-19 7:48:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DeleteBountyQuestion]
(
	@BountyId INT
)
AS
BEGIN
	
	DELETE FROM [dbo].[Bounty] WHERE Id=@BountyId
	
END