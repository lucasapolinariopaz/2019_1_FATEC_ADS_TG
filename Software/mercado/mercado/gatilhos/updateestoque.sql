CREATE TRIGGER updateestoque
   ON  [dbo].[detalheVenda]
   AFTER  insert
AS 
BEGIN

     UPDATE estoque SET estoque_atualprod=estoque_atualprod-dt.unidades from inserted dt where codigo_prod=dt.codProdV
	 
 
END