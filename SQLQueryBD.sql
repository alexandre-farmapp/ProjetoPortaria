CREATE TABLE [dbo].[Condominios] (
    [Cod]  INT          IDENTITY (1, 1) NOT NULL,
    [nome] VARCHAR (50) NULL,
    [tipo] VARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Cod] ASC)
)

CREATE TABLE [dbo].[moradores] (
    [Cod_morador] INT           IDENTITY (1, 1) NOT NULL,
    [Nome]        VARCHAR (50)  NOT NULL,
    [CPF]         VARCHAR (14)  NOT NULL,
    [Rua]         VARCHAR (50)  NOT NULL,
    [Unidade]     INT           NOT NULL,
    [ramal]       INT           NULL,
    [fixo]        VARCHAR (13)  NULL,
    [celular]     VARCHAR (14)  NOT NULL,
    [Email]       VARCHAR (50)  NULL,
    [Observacoes] VARCHAR (250) NULL,
    [foto]        VARCHAR (MAX) NULL,
    [modelo]      VARCHAR (15)  NULL,
    [cor]         VARCHAR (15)  NULL,
    [placa]       VARCHAR (8)   NULL,
    [condominio]  VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Cod_morador] ASC)
)

CREATE TABLE [dbo].[ocorrencias] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [unidade]    VARCHAR (50)   NOT NULL,
    [rua]        VARCHAR (50)   NOT NULL,
    [data]       VARCHAR (50)   NOT NULL,
    [hora]       VARCHAR (2)    NOT NULL,
    [min]        VARCHAR (2)    NOT NULL,
    [ocorrencia] VARCHAR (1000) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)

CREATE TABLE [dbo].[pessoasuteis] (
    [Id]                  INT          IDENTITY (1, 1) NOT NULL,
    [nome_sindico]        VARCHAR (50) NULL,
    [telefone_sindico]    VARCHAR (15) NULL,
    [nome_supervisor]     VARCHAR (50) NULL,
    [telefone_supervisor] VARCHAR (15) NULL,
    [nome_zelador]        VARCHAR (50) NULL,
    [telefone_zelador]    VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)

CREATE TABLE [dbo].[relatorio] (
    [Cod_visitante]    INT           IDENTITY (1, 1) NOT NULL,
    [Nome]             VARCHAR (50)  NOT NULL,
    [CPF]              VARCHAR (14)  NULL,
    [visitado]         VARCHAR (50)  NULL,
    [Unidade]          INT           NOT NULL,
    [blocoRua]         VARCHAR (20)  NULL,
    [Telefone_celular] VARCHAR (14)  NULL,
    [Observacoes]      VARCHAR (250) NULL,
    [foto]             VARCHAR (MAX) NULL,
    [entrada]          DATETIME      NULL,
    [saida]            DATETIME      NULL,
    [condominio]       VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Cod_visitante] ASC)
)

CREATE TABLE [dbo].[Servidor] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [nomeServidor] VARCHAR (50) NOT NULL,
    [bancoDados]   VARCHAR (25) NOT NULL,
    [usuario]      VARCHAR (20) NULL,
    [senha]        VARCHAR (15) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)

CREATE TABLE [dbo].[temporarios] (
    [Idvisitante] INT           IDENTITY (1, 1) NOT NULL,
    [nome]        VARCHAR (50)  NULL,
    [cpf]         VARCHAR (15)  NULL,
    [celular]     VARCHAR (15)  NULL,
    [entrada]     DATETIME      NULL,
    [visitado]    VARCHAR (50)  NULL,
    [carro]       VARCHAR (20)  NULL,
    [placa]       VARCHAR (8)   NULL,
    [foto]        VARCHAR (MAX) NULL,
    [ruaBloco]    VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Idvisitante] ASC)
)

CREATE TABLE [dbo].[usuarios] (
    [Cod]     INT          IDENTITY (1, 1) NOT NULL,
    [usuario] VARCHAR (20) NOT NULL,
    [senha]   VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([Cod] ASC)
)

CREATE TABLE [dbo].[visitantes] (
    [Cod_morador]      INT           IDENTITY (1, 1) NOT NULL,
    [Nome]             VARCHAR (50)  NOT NULL,
    [CPF]              VARCHAR (14)  NOT NULL,
    [visitado]         VARCHAR (50)  NOT NULL,
    [Unidade]          INT           NOT NULL,
    [Telefone_celular] VARCHAR (14)  NULL,
    [Observacoes]      VARCHAR (250) NULL,
    [foto]             VARCHAR (MAX) NULL,
    [modelo]           VARCHAR (15)  NULL,
    [placa]            VARCHAR (8)   NULL,
    [ruaBloco]         VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Cod_morador] ASC)
)