using Acme.BookStore.Students;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books;

public class StudentService :
    CrudAppService<
        Student, //The Book entity
        StudentDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateStudentDto>, //Used to create/update a book
    IStudentService //implement the IStudentService
{
    public StudentService(IRepository<Student, Guid> repository)
        : base(repository)
    {

    }
}
