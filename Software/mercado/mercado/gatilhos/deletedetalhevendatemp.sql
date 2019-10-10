CREATE TRIGGER del_detalhevendatemp
   ON  [dbo].[estoque]
   AFTER  update
AS 
BEGIN
	 DELETE FROM [dbo].[detalheVendatemp]
    
END
