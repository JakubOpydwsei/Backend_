using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using System.Collections.Generic;
using WebApi.DTO;


namespace BackendLab01; 
public class QuizDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<QuizIteamDTO> Items { get; set; }
    public static QuizDTO of(Quiz quiz)
    {
        QuizDTO dto = new QuizDTO();
        dto.Id = quiz.Id;
        dto.Title = quiz.Title;
        foreach (var quizItem in quiz.Items)
        {
            dto.Items.Add(QuizIteamDTO.of(quizItem));
        }
        return dto;

    }
}
