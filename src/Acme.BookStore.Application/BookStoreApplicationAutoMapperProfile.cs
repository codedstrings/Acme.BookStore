using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using Acme.BookStore.Students;
using AutoMapper;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<Student, StudentDto>();
        CreateMap<CreateUpdateStudentDto, StudentDto>();
        CreateMap<Author, AuthorDto>();

    }
}
