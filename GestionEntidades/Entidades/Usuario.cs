﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEntidades.Entidades;

public class Usuario
{
    [Key]
    public string Id { get; set; }
}
