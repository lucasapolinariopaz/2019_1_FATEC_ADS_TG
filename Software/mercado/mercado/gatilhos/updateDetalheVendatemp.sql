CREATE TRIGGER inserirdetUpestoque
   ON  [dbo].[Venda]
   AFTER  INSERT
AS 
BEGIN
	DECLARE     @codigo_venda int;
	Declare     @codigo_cli int;

	SELECT @codigo_venda= pd.cod_venda from inserted pd
	
	update detalheVendatemp set codDetV=@codigo_venda
	
	SELECT @codigo_cli= pd.codcliV from inserted pd
	if(@codigo_cli!=0)
		insert into debitoscli
	       ([valordeb]
		   ,[datadeb]
           ,[cod_clideb]
           ,[vendacli])
	    select
			valTotal,
		    datavenda,
			codcliV,
			cod_venda
		from inserted

END