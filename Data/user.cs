
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace consumeapiinblazor.Data
{
    public class user:ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        [Parameter]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Parameter]
        public string Email { get; set; }
    }
}
