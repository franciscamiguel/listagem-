CREATE TABLE Compradores (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome_razao_social VARCHAR(150) NOT NULL,
    email VARCHAR(150) NOT NULL,
    telefone VARCHAR(11) NOT NULL,
    data_cadastro DATE NOT NULL,
    cliente_bloqueado BOOLEAN NOT NULL,
    senha_acesso VARCHAR(15) NOT NULL,
    tipo_pessoa ENUM('Física', 'Jurídica') NOT NULL,
    cpf_cnpj VARCHAR(14) NOT NULL,
    inscricao_estadual VARCHAR(12),
    UNIQUE(email),
    UNIQUE(cpf_cnpj)
);
