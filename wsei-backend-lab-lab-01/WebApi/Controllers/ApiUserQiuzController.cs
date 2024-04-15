using BackendLab01;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.DTO;


namespace WebApi.Controllers;
[ApiController]
[Route("/api/v1/user/quizzes")]
public class ApiUserQiuzController : ControllerBase
{
    private IQuizUserService _userService;
    private IQuizAdminService _adminservice;

    public ApiUserQiuzController(IQuizUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    [Route("{id}")]

    public ActionResult<QuizDTO> FindById(int id)
    {
        Quiz quiz = _userService.FindQuizById(id);
        if (quiz != null)
        {
            QuizDTO quizDto = QuizDTO.of(quiz);
            return Ok(quizDto);
        }
        else
        {
            return NotFound();
        }
    }
    [HttpGet]
    public IEnumerable<QuizDTO> FindAll()
    {
        IEnumerable<Quiz> quizzes = (IEnumerable<Quiz>)_adminservice.FindAllQuizItems();
        List<QuizDTO> list = new List<QuizDTO>();
        foreach (var quiz in quizzes)
        {
            QuizDTO quizDto = QuizDTO.of(quiz);
            list.Add(quizDto);
        }
        return list;
    }

    [HttpPost]
    [Route("{quizId}/items/{itemId}/answers")]
    public void SaveAnswer([FromBody] QuizItemUserAnswerDTO dto, int quizId, int quizItemId)
    {
        int userId = dto.UserId;
        string answer = dto.Answer;
        _userService.SaveUserAnswerForQuiz(quizId, userId, quizItemId, answer);
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
