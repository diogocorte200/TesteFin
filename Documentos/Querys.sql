use DbTesteApp

select * from tbCliente c
join TbFinanciamento f on f.idCliente = c.idCliente
join TbParcela p on p.IdFinanciamento = f.IdFinanciamento
where c.uf = 'SP'
and p.NumParcelas >= 30



select top 4 * from tbCliente c
join TbFinanciamento f on f.idCliente = c.idCliente
join TbParcela p on p.IdFinanciamento = f.IdFinanciamento
where p.DataVencmento > getdate() and p.DataPagamento is null


select * from tbCliente c
join TbFinanciamento f on f.idCliente = c.idCliente
join TbParcela p on p.IdFinanciamento = f.IdFinanciamento
where p.DataPagamento > p.DataVencmento
and ValorTotal > 1000000


