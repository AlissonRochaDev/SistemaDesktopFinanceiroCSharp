--Cadastrar Dados do Usuário
INSERT INTO tb_usuario
(nome_usuario, email_usuario, senha_usuario, data_cadastro)
VALUES
('Ana Maria', 'ana.maria@gmail.com', 'ana321', GETDATE());

INSERT INTO tb_usuario
(nome_usuario, email_usuario, senha_usuario, data_cadastro)
VALUES
('Jose Frederico', 'jose.fred@gmail.com', 'fred321', GETDATE());

INSERT INTO tb_categoria
(nome_categoria, id_usuario)
VALUES
('Faculdade', 1);

INSERT INTO tb_categoria
(nome_categoria, id_usuario)
VALUES
('Mercado', 2);

INSERT INTO tb_empresa
(nome_empresa, telefone_empresa, endereco_empresa, id_usuario)
VALUES
('UNOPAR', '4333220022', 'Rua Comercial Nº120', 1);

INSERT INTO tb_empresa
(nome_empresa, telefone_empresa, endereco_empresa, id_usuario)
VALUES
('Muffato', '4333552266', 'Rua Teste Nº200', 2);

INSERT INTO tb_conta
(banco_conta, agencia_conta, numero_conta, saldo_conta, id_usuario)
VALUES
('Nubank', '001', '0895959', 2620.56, 1);

INSERT INTO tb_conta
(banco_conta, agencia_conta, numero_conta, saldo_conta, id_usuario)
VALUES
('Itau', '718', '69466231', 2620.56, 2);

INSERT INTO tb_movimento
(tipo_movimento, data_movimento, valor_movimento, obs_movimento, id_categoria, id_empresa, id_conta, id_usuario)
VALUES
(0, '2025-04-05', 520, null, 1, 1, 1, 1);

--Consultar Dados do Usuário
SELECT * FROM tb_usuario;

SELECT * FROM tb_categoria;

SELECT * FROM tb_empresa;

SELECT * FROM tb_conta;

SELECT * FROM tb_movimento;

--Atualizar Dados do Usuário
UPDATE tb_usuario
	SET nome_usuario = 'Bruno Silva'
WHERE id_usuario = 2;

UPDATE tb_usuario
	SET nome_usuario = 'Bruno Silva',
		email_usuario = 'bruno_silva@hotmail.com',
		senha_usuario = 'bru222'
WHERE id_usuario = 2;

--Atualizar Dados do Usuário
DELETE FROM tb_usuario WHERE id_usuario = 3;

--Busca de Dados utilizando Filtro (WHERE)
SELECT * FROM tb_categoria WHERE id_usuario = 1;

SELECT * FROM tb_empresa WHERE id_usuario = 1;

SELECT * FROM tb_conta WHERE id_usuario = 1;

SELECT * FROM tb_movimento WHERE id_movimento = 1 AND id_usuario = 1;

SELECT nome_usuario, nome_categoria, nome_empresa 
	FROM tb_usuario
INNER JOIN tb_categoria
	ON tb_categoria.id_usuario = tb_usuario.id_usuario
INNER JOIN tb_empresa
	ON tb_empresa.id_usuario = tb_usuario.id_usuario;

SELECT * FROM tb_usuario 
	INNER JOIN tb_categoria
ON tb_categoria.id_usuario = tb_usuario.id_usuario;

SELECT nome_usuario, 
		nome_categoria, 
		nome_empresa, 
		banco_conta, 
		saldo_conta
	FROM tb_usuario
INNER JOIN tb_categoria
	ON tb_categoria.id_usuario = tb_usuario.id_usuario
INNER JOIN tb_empresa
	ON tb_empresa.id_usuario = tb_usuario.id_usuario
INNER JOIN tb_conta	
	ON tb_conta. id_usuario = tb_usuario.id_usuario;

--Tipo do Movimento: 0 Entrada - 1 Saída
SELECT nome_usuario, 
		tipo_movimento, 
		data_movimento, 
		valor_movimento, 
		nome_categoria,
		nome_empresa,
		banco_conta,
		numero_conta,
		saldo_conta,
		obs_movimento
	FROM tb_usuario
INNER JOIN tb_categoria
	ON tb_categoria.id_usuario = tb_usuario.id_usuario
INNER JOIN tb_empresa
	ON tb_empresa.id_usuario = tb_usuario.id_usuario
INNER JOIN tb_conta
	ON tb_conta.id_usuario = tb_usuario.id_usuario
INNER JOIN tb_movimento
	ON tb_movimento.id_usuario = tb_usuario.id_usuario;

SELECT nome_usuario, 
		tipo_movimento, 
		data_movimento, 
		valor_movimento, 
		nome_categoria,
		nome_empresa,
		banco_conta,
		numero_conta,
		saldo_conta,
		obs_movimento
	FROM tb_usuario
INNER JOIN tb_categoria
	ON tb_categoria.id_usuario = tb_usuario.id_usuario
INNER JOIN tb_empresa
	ON tb_empresa.id_usuario = tb_usuario.id_usuario
INNER JOIN tb_conta
	ON tb_conta.id_usuario = tb_usuario.id_usuario
INNER JOIN tb_movimento
	ON tb_movimento.id_usuario = tb_usuario.id_usuario
WHERE tb_movimento.tipo_movimento = 1;

SELECT nome_usuario, 
		tipo_movimento, 
		data_movimento, 
		valor_movimento, 
		nome_categoria,
		nome_empresa,
		banco_conta,
		numero_conta,
		saldo_conta,
		obs_movimento
	FROM tb_usuario
INNER JOIN tb_categoria
	ON tb_categoria.id_usuario = tb_usuario.id_usuario
INNER JOIN tb_empresa
	ON tb_empresa.id_usuario = tb_usuario.id_usuario
INNER JOIN tb_conta
	ON tb_conta.id_usuario = tb_usuario.id_usuario
INNER JOIN tb_movimento
	ON tb_movimento.id_usuario = tb_usuario.id_usuario
WHERE tb_movimento.tipo_movimento = 0
	AND tb_movimento.id_usuario = 1;