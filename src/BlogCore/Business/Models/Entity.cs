﻿using Microsoft.AspNetCore.Identity;

namespace BlogCore.Business.Models
{
    public abstract class Entity
    {
        public long Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
