using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public class GameCommentDTO : GameDTO
    {
        public List<CommentDTO> Comments { get; set; }
        public UserDTO User { get; set; }
        public GameCommentDTO()
        {
            Comments = new List<CommentDTO>();
        }
    }
}
