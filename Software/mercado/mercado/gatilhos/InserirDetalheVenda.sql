
create TRIGGER [dbo].[inserirdetalhevenda]
   ON  [dbo].[detalheVendatemp]
   AFTER  update
AS 
BEGIN
	
	--DECLARE		   @codProdV int
  --  DECLARE        @codDetV int;
 --   DECLARE        @marca varchar(50);
  --  DECLARE        @descProdV varchar(50);
 --   DECLARE        @valorUniV decimal(18,2);
--    DECLARE        @unidades int;
 --   DECLARE        @subValortotal decimal(18,2);
--	SELECT @codProdV= pd.codProdV from inserted pd
--	SELECT @codDetV= pd.codDetV from inserted pd
--	SELECT @marca= pd.marca from inserted pd
--	SELECT @descProdV= pd.descProdV from inserted pd
--	SELECT @valorUniV= pd.valorUniV from inserted pd
--	SELECT @unidades= pd.unidades from inserted pd
--	SELECT @subValortotal= pd.subValortotal from inserted pd
	insert into detalheVenda
	       (  codProdV,
             codDetV
            ,marca
           ,descProdV
           ,valorUniV
           ,unidades
           ,subValortotal)
     --VALUES
          -- (		 
		   SELECT codProdV ,
            codDetV, 
            marca ,
            descProdV ,
            valorUniV ,
            unidades ,
            subValortotal
			from inserted
			--)


END

