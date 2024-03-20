using BackendLab01;

namespace WebApi.DTO;

public class QuizIteamDTO
{
    
    public int Id { get; set; }
    public string Question { get; set; }
    public List<string> Options { get; set; }

    public static QuizIteamDTO Of(QuizItem item)
    {
        return new QuizIteamDTO()
        {
            Id = item.Id,
            Question = item.Question,
            Options = new List<string>(item.IncorrectAnswers)
            {
                item.CorrectAnswer
            }
            
        };
    }
    
}