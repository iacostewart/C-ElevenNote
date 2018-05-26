using ElevenNote.Models;
using ElevenNote.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElevenNote.Web.Controllers.WebAPI
{
    public class NoteController : ApiController
    {

        private bool SetStarState(int noteId, bool newState)
        {
            // create the service 
            var userID = Guid.Parse(User.Identity.GetUserId());
            var service = new NoteService(userId);

            // get the note 
            var detail = service.GetNoteById(noteId);

            // Create the NoteEdit model instance with the new star state 
            var updateNote =
                    new NoteEdit
                    {
                        noteId = detail.NoteId,
                        Title = detail.Title,
                        Content = detail.Content,
                        IsStarred = newState
                    };

            // Create the 
        }

        [Route("{id}/Star")]
        [HttpPut]
        public bool ToggleStarOn(int id) => SetStarState(id, true);

        [Route("{id}/Star")]
        [HttpDelete]
        public bool ToggleStarOff(int id) => SetStarState(id, false);
    }
}
