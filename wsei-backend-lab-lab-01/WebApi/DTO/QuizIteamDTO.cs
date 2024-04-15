using BackendLab01;

namespace WebApi.DTO;
public class QuizIteamDTO
{
    public int Id { get; set; }
    public string Question { get; set; }
    public List<string> Options { get; }
    public static QuizIteamDTO of(QuizItem quiz)
    {
        QuizIteamDTO qidto = new QuizIteamDTO();
        qidto.Id = quiz.Id;
        qidto.Question = quiz.Question;
        List<string> answers = new List<string>();
        answers.Add(quiz.CorrectAnswer);
        answers.AddRange(quiz.IncorrectAnswers);

        Random rnd = new Random();
        answers = answers.OrderBy(x => rnd.Next()).ToList();

        return qidto;


    }
}