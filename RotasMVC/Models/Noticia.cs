using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace RotasMVC.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Categoria { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
            {
                new Noticia
                {
                    NoticiaId   = 1,
                    Categoria   = "Esportes",
                    Titulo      = "Felipe Massa chora no Brasil",
                    Conteudo    = "Brasileiro liderava última volta quando deixou carro morrer. Rubinho deu risada no twitter...",
                    Data        = new DateTime(2012,7,5)
                },

                new Noticia
                {
                    NoticiaId   = 2,
                    Categoria   = "Política",
                    Titulo      = "Vereadores ganham aumento de R$15000",
                    Conteudo    = "Novo reajuste salarial foi comemorado pelo nobres parlamentares: - É só o começo!",
                    Data        = new DateTime(2012,7,3)
                },

                new Noticia
                {
                    NoticiaId   = 3,
                    Categoria   = "Política",
                    Titulo      = "Vereador é eleito pela 4º vez",
                    Conteudo    = "Vereador de Mococa é eleito novamente. Suspeita de fruade eleitoral no ar...",
                    Data        = new DateTime(2012,7,20)
                },

                new Noticia
                {
                    NoticiaId   = 4,
                    Categoria   = "Humor",
                    Titulo      = "Rafinha basto é um idota",
                    Conteudo    = "Pesquina nacional aponta Rafinha Bastos como o maior idota já existente na face da Terra...",
                    Data        = new DateTime(2012,7,18)
                },

                new Noticia
                {
                    NoticiaId   = 5,
                    Categoria   = "Esporte",
                    Titulo      = "Todo Poderoso Timão",
                    Conteudo    = "Corinthians bate Real Madrid na semi, e novamente freguês Barça na final da Champions League",
                    Data        = new DateTime(2012,7,14)
                },
                new Noticia
                {
                    NoticiaId   = 6,
                    Categoria   = "Humor",
                    Titulo      = "Didi é pego fazendo troca-troca",
                    Conteudo    = "Humorista dos trapalhões é pego atras da moita com seu fiel parceiro Dede Santana.",
                    Data        = new DateTime(2012,7,19)
                },
                new Noticia
                {
                    NoticiaId   = 7,
                    Categoria   = "Política",
                    Titulo      = "Aecio Neves é internado com overdose",
                    Conteudo    = "Candidato a presidencia do Brasil da entrada no Albert Einstein com overdose de cocaína. Familiares dizem que foi armação do PT...",
                    Data        = new DateTime(2012,7,8)
                },
            };
            return retorno;
        }
    }
}