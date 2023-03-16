using LinkedLists.Service.Absolute;
using Microsoft.AspNetCore.Mvc;

namespace LinkedLists.Api.Controllers
{
    /// <summary>
    /// Singly linked list controller.
    /// </summary>
    [ApiController]
    [Route("singly-linked-lists")]
    public class SinglyLinkedListsController : ControllerBase
    {
        private readonly ISinglyLinkedListService _singlyLinkedListService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="singlyLinkedListService">Handle singly linked list service</param>
        public SinglyLinkedListsController(ISinglyLinkedListService singlyLinkedListService)
        {
            _singlyLinkedListService = singlyLinkedListService;
        }
    }
}