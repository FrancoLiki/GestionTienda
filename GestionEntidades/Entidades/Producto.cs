using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEntidades.Entidades;

public class Producto
{
    [Key]
    public string Id { get; set; }
}
