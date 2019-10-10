create TRIGGER [dbo].[atuabe]
   ON  [fechamento]
   AFTER  INSERT
AS 
BEGIN  
	  update abertura set estatus='OFF'
		 
    
END