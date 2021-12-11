using System.ComponentModel.DataAnnotations;

namespace MvcTodo.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        // #nullable enable
        public string? Content { get; set; }
        // #nullable disable
        
        [DataType(DataType.Date)]
        public DateTime? CreatedDate { get; set; }
        public Boolean Completed { get; set; }
    }
}