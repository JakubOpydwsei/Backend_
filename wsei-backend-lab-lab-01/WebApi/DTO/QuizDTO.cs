using BackendLab01;

namespace WebApi.DTO;

public class QuizDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<QuizIteamDTO>Items {get; set; }

    public static QuizDTO Of(Quiz quiz)
    {
        return new QuizDTO()
        {
            Id = quiz.Id,
            Title = quiz.Title,
            Items = quiz.Items.Select(item => QuizIteamDTO.Of(item)).ToList()
        };
    }
    
}