using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Books;

public class StudentDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }
    public DateTime DOB { get; set; }
    public string Address { get; set; }
}
