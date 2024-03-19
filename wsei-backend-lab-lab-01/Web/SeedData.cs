using ApplicationCore.Interfaces.Repository;
using BackendLab01;

namespace Infrastructure.Memory;
public static class SeedData
{
    public static void Seed(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var provider = scope.ServiceProvider;
            var quizRepo = provider.GetService<IGenericRepository<Quiz, int>>();
            var quizItemRepo = provider.GetService<IGenericRepository<QuizItem, int>>();


            //Quizz nr 1:
            {
                List<QuizItem> quizItems = new List<QuizItem>();


                quizItems.Add(quizItemRepo.Add(
                    new QuizItem(
                        id: 1,
                        correctAnswer: "Right",
                        question: "Question",

                    incorrectAnswers:
                    new List<string>() { "Wrong", "Wrong" }
                    )
                    )
                    );


                quizItems.Add(quizItemRepo.Add(
                    new QuizItem(
                        id: 2,
                        correctAnswer: "Right",
                        question: "Question",

                    incorrectAnswers:
                    new List<string>() { "Wrong", "Wrong" }
                    )
                    )
                    );


                quizItems.Add(quizItemRepo.Add(
                    new QuizItem(
                        id: 3,
                        correctAnswer: "Right",
                        question: "Question",

                    incorrectAnswers:
                    new List<string>() { "Wrong", "Wrong" }
                    )
                    )
                    );

                quizItems.Add(quizItemRepo.Add(
                    new QuizItem(
                        id: 4,
                        correctAnswer: "Right",
                        question: "Question",

                    incorrectAnswers:
                    new List<string>() { "Wrong", "Wrong" }
                    )
                    )
                    );

                quizItems.Add(quizItemRepo.Add(
                    new QuizItem(
                        id: 5,
                        correctAnswer: "Right",
                        question: "Question",

                    incorrectAnswers:
                    new List<string>() { "Wrong", "Wrong" }
                    )
                    )
                    );

                quizRepo.Add(new Quiz(id: 1, items: quizItems, title: "Question1"));
            }

            //Quiz nr 2:
            {
                List<QuizItem> quizItems2 = new List<QuizItem>();


                quizItems2.Add(quizItemRepo.Add(
                    new QuizItem(
                        id: 1,
                        correctAnswer: "Right",
                        question: "Question",

                    incorrectAnswers:
                    new List<string>() { "Wrong", "Wrong" }
                    )
                    )
                    );


                quizItems2.Add(quizItemRepo.Add(
                    new QuizItem(
                        id: 2,
                        correctAnswer: "Right",
                        question: "Question",

                    incorrectAnswers:
                    new List<string>() { "Wrong", "Wrong" }
                    )
                    )
                    );


                quizItems2.Add(quizItemRepo.Add(
                    new QuizItem(
                        id: 3,
                        correctAnswer: "Right",
                        question: "Question",

                    incorrectAnswers:
                    new List<string>() { "Wrong", "Wrong" }
                    )
                    )
                    );

                quizItems2.Add(quizItemRepo.Add(
                    new QuizItem(
                        id: 4,
                        correctAnswer: "Right",
                        question: "Question",

                    incorrectAnswers:
                    new List<string>() { "Wrong", "Wrong" }
                    )
                    )
                    );

                quizItems2.Add(quizItemRepo.Add(
                    new QuizItem(
                        id: 5,
                        correctAnswer: "Right",
                        question: "Question",

                    incorrectAnswers:
                    new List<string>() { "Wrong", "Wrong" }
                    )
                    )
                    );

                quizRepo.Add(new Quiz(id: 2, items: quizItems2, title: "Quiz 2"));
            }

            //Quiz nr3:
            {
                List<QuizItem> quizItems3 = new List<QuizItem>();


                quizItems3.Add(quizItemRepo.Add(
                    new QuizItem(
                        id: 1,
                        correctAnswer: "Right",
                        question: "Question",

                    incorrectAnswers:
                    new List<string>() { "Wrong", "Wrong" }
                    )
                    )
                    );


                quizItems3.Add(quizItemRepo.Add(
                    new QuizItem(
                        id: 2,
                        correctAnswer: "Right",
                        question: "Question",

                    incorrectAnswers:
                    new List<string>() { "Wrong", "Wrong" }
                    )
                    )
                    );


                quizItems3.Add(quizItemRepo.Add(
                    new QuizItem(
                        id: 3,
                        correctAnswer: "Right",
                        question: "Question",

                    incorrectAnswers:
                    new List<string>() { "Wrong", "Wrong" }
                    )
                    )
                    );

                quizItems3.Add(quizItemRepo.Add(
                    new QuizItem(
                        id: 4,
                        correctAnswer: "Right",
                        question: "Question",

                    incorrectAnswers:
                    new List<string>() { "Wrong", "Wrong" }
                    )
                    )
                    );

                quizItems3.Add(quizItemRepo.Add(
                    new QuizItem(
                        id: 5,
                        correctAnswer: "Right",
                        question: "Question",

                    incorrectAnswers:
                    new List<string>() { "Wrong", "Wrong" }
                    )
                    )
                    );

                quizRepo.Add(new Quiz(id: 3, items: quizItems3, title: "Quiz 3"));
            }

        }
    }
}