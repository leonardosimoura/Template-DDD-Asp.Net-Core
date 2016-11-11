# Template-DDD-Asp.Net-Core


##DDL for teste

###SQL
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](200) NOT NULL,
	[Email] [varchar](200) NOT NULL,
	[Senha] [varchar](200) NOT NULL,
	[DataRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

###Postgres

CREATE TABLE "Usuario"
(
  "IdUsuario" serial NOT NULL,
  "Nome" character varying(200) NOT NULL,
  "Email" character varying(200) NOT NULL,
  "Senha" character varying(200) NOT NULL,
  "DataRegistro" timestamp without time zone NOT NULL
);
