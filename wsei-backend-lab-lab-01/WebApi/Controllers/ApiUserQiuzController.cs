using BackendLab01;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTO;

namespace WebApi.Controllers;
[ApiController]
[Route("/api/v1/user/quizzes")]
public class ApiUserQiuzController : ControllerBase
{
    private IQuizUserService _userService;

    public ApiUserQiuzController(IQuizUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    [Route(template: "{id}")]
    public ActionResult<QuizDTO?> GetQuizById(int id)
    {
        
        var result=_userService.FindQuizById(id);
        if (result is null)
        {
            return NotFound();
        }else
        {
            return QuizDTO.Of(result);
        }
    }

    [HttpPost]
    [Route("{quizId}/items/{itemId}/answers")]
    public ActionResult SaveAnswer(int quizId, int itemId, QuizItemUserAnswerDTO answer)
    {
        _userService.SaveUserAnswerForQuiz(quizId,1, itemId, answer.Answer);
        return Created();
    }

    [HttpGet]
    [Route("{quizId}/answers")]
    public ActionResult<object> CountCorrectAnswers(int quizId)
    {
        int count = _userService.CountCorrectAnswersForQuizFilledByUser(quizId, 1);
        return new
        {
            ValidAnswers = count,
            QuizId = quizId,
            UserId = 1
        };
    }

}

// Api admin quiz controler aby sterować quizami
// kiedy można usuwać quizy 
// dodawanie i usuwanie zrobić