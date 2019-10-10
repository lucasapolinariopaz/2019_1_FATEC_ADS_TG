/*    ==Parâmetros de Script==

    Versão do Servidor de Origem : SQL Server 2014 (12.0.2269)
    Edição do Mecanismo de Banco de Dados de Origem : Microsoft SQL Server Express Edition
    Tipo do Mecanismo de Banco de Dados de Origem : SQL Server Autônomo

    Versão do Servidor de Destino : SQL Server 2017
    Edição de Mecanismo de Banco de Dados de Destino : Microsoft SQL Server Standard Edition
    Tipo de Mecanismo de Banco de Dados de Destino : SQL Server Autônomo
*/

USE [mercado_tg]
GO
/****** Object:  Trigger [dbo].[insertprodestoqu]    Script Date: 23/04/2019 18:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER TRIGGER [dbo].[insertprodestoqu]
   ON  [dbo].[produtoentrada]
   AFTER  INSERT
AS 
BEGIN
	  DECLARE     @codigo_prod int;
	  DECLARE     @codigo_barra varchar(50);
      DECLARE     @descricao_prod varchar(50);
      DECLARE     @categoria_prod varchar(50);
      DECLARE     @marca_prod varchar(50);
      DECLARE     @preco_custo decimal(18,2);
      DECLARE     @preco_venda decimal(18,2);
      DECLARE     @unidades int;
	  DECLARE     @estoque_atualprod int;
      DECLARE     @validade_prod varchar(50);
      DECLARE     @codprod_fornec int;
      DECLARE     @data_entrada varchar(50);
	DECLARE	      @soma int;

	      SELECT @codigo_prod= pd.codigo_prod from inserted pd
		  SELECT @codigo_barra=pd.codigo_barra from inserted pd
		  SELECT @descricao_prod=pd.descricao_prod from inserted pd
		  SELECT @categoria_prod=pd.categoria_prod from inserted pd
		  SELECT @marca_prod=pd.marca_prod from inserted pd
		  SELECT @preco_custo=pd.preco_custo from inserted pd
		  SELECT @preco_venda=pd.preco_venda from inserted pd
		  SELECT @estoque_atualprod=pd.estoque_atualprod from inserted pd
		  SELECT @validade_prod=pd.validade_prod from inserted pd
		  SELECT @codprod_fornec=pd.codprod_fornec from inserted pd
		  SELECT @unidades=pd.unidades from inserted pd
		  
		  SELECT @data_entrada=pd.data_entrada from inserted pd
		  SELECT @soma=@estoque_atualprod+ @unidades from inserted 
		  --SELECT @soma=pd.estoquenovo from inserted pd--
	  
	  
	  insert into estoque
	   (   codigo_barra
           ,descricao_prod
           ,categoria_prod
           ,marca_prod
           ,preco_custo
           ,preco_venda
           ,estoque_atualprod
           ,validade_prod
           ,codprod_fornec
           
           ,data_entrada,
          codprodentrada
		   )
     VALUES
           (
		  @codigo_barra
		  ,@descricao_prod
		  ,@categoria_prod
		  ,@marca_prod
		  ,@preco_custo
		   ,@preco_venda
		   ,@soma 
		   ,@validade_prod
		  ,@codprod_fornec 
		  ,@data_entrada
		  ,@codigo_prod)


END
