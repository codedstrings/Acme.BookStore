using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Books;

public class CreateUpdateStudentDto
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Date)]
    public DateTime DOB { get; set; } = DateTime.Now;

    [Required]
    public string Address { get; set; } = string.Empty;

}
