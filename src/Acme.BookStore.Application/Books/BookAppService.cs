using System;
using System.Threading.Tasks;
using Volo.Abp.Account;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    //dependency injection
    private readonly IRepository<Book> _bookRepository; 
    public BookAppService(IRepository<Book, Guid> bookRepository)
        : base(bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public override Task<BookDto> CreateAsync(CreateUpdateBookDto input)
    {
        input.Name = input.Name + "Mridhul";
        return base.CreateAsync(input);
    }

    public override Task<BookDto> GetAsync(Guid id)
    {
        return base.GetAsync(id);
    }

    public override Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        return base.GetListAsync(input);
    }
    
    public void CreateBookSample(CreateUpdateBookDto input)
    {
        //manual mapping
        Book bookEntity = new Book() 
        {
            Name = input.Name,
            Type=input.Type,
            PublishDate=input.PublishDate,
            Price=input.Price,
        };

        //automapping
        Book bookEntity2 = ObjectMapper.Map<CreateUpdateBookDto, Book>(input);
        _bookRepository.InsertAsync(bookEntity);
    }
    public void Hello()
    {

    }
}
