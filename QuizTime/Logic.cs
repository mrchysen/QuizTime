using System.Collections.Generic;
using System.IO;
using System;
using System.Linq.Expressions;

// Пространство с логикой приложения
namespace LogicOfApplication 
{
    // Логика вопросов и класс-контейнер для вопросов
    namespace QuestionsAndBoxes
    {
        // Обычные вопрос с ответом да/нет \\
        public class Question
        {
            // Поля: Текст вопроса, Номер ответа на вопрос, Сложность вопроса \\
            protected string QuestionText;
            protected int Answer;
            protected int Dificulty;

            // Св-ва \\
            public string GetText => QuestionText;
            public int GetDificulty => Dificulty;

            // Конструкторы \\
            /// <summary>
            /// AnswerOnQuestion = 0(Yes) or AnswerOnQuestion = 1(No)
            /// </summary>
            /// <param name="TextOfQuestion"></param>
            /// <param name="AnswerOnQuestion"></param>
            public Question(string TextOfQuestion, int AnswerOnQuestion, int DificultOfQuestion)
            {
                QuestionText = TextOfQuestion;
                Dificulty = DificultOfQuestion;
                if (AnswerOnQuestion > 1 || AnswerOnQuestion < 0)
                {
                    Answer = 0;
                }
                else
                {
                    Answer = AnswerOnQuestion;
                }
            }

            // Методы \\
            /// <summary>
            /// Метод проверяющий правильность ответа InputAnswer
            /// </summary>
            /// <param name="InputAnswer"></param>
            /// <returns></returns>
            public virtual bool Quiz(int InputAnswer) // InputAnswer = 1(Yes) or InputAnswer = 2(No)
            {
                return (Answer == InputAnswer - 1);
            }
            /// <summary>
            /// Метод сохранения в текстовый файл
            /// </summary>
            /// <param name="Sw"></param>
            public virtual void SaveIntoTxtFile(StreamWriter Sw)
            {
                Sw.WriteLine(QuestionText);
                Sw.WriteLine($"Сложность:{Dificulty}");
                string ans = (Answer == 0) ? "Да" : "Нет";
                Sw.WriteLine(ans);
            }
            public override string ToString()
            {
                return GetText + "(1 Да/2 Нет)";
            }
            
        }

        // Вопросы с множественным ответом
        public class MultiQuestion : Question
        {
            // Поля \\
            protected List<string> Answers = new List<string>();

            // Св-ва \\
            public List<string> GetAllAnswers => Answers;

            // Конструкторы \\
            /// <summary>
            /// AnswerOnQuestion = [0, ListWithAnswers.Length - 1]; ListWithAnswers[AnswerOnQuestion] = True Answer
            /// </summary>
            /// <param name="TextOfQuestion"></param>
            /// <param name="AnswerOnQuestion"></param>
            /// <param name="ListWithAnswers"></param>
            public MultiQuestion(string TextOfQuestion, int AnswerOnQuestion, int DificultOfQuestion, List<string> ListWithAnswers) : base(TextOfQuestion, AnswerOnQuestion, DificultOfQuestion)
            {
                Answers = ListWithAnswers;
            }

            // Методы \\
            /// <summary>
            /// if ListWithAnswers[InputAnswer - 1] = True Answer then return true
            /// else false
            /// </summary>
            /// <param name="InputAnswer"></param>
            /// <returns></returns>
            public override bool Quiz(int InputAnswer)
            {
                return (Answer == InputAnswer - 1);
            }

            /// <summary>
            /// Метод сохранения в текстовый файл
            /// </summary>
            /// <param name="Sw"></param>
            public override void SaveIntoTxtFile(StreamWriter Sw)
            {
                Sw.WriteLine(QuestionText);
                Sw.WriteLine($"Сложность:{Dificulty}");
                for (int i = 0; i < Answers.Count; i++)
                {
                    string Remark = (i == Answer) ? Answers[i] + "(*)" : Answers[i];
                    Sw.WriteLine(Remark);
                }
                
            }

            public override string ToString()
            {
                string questions = "\n";
                for (int i = 0; i < Answers.Count - 1; i++)
                {
                    questions += $"{i + 1}) " + Answers[i] + "\n";
                }
                questions += $"{Answers.Count}) " + Answers[Answers.Count - 1];
                return GetText + questions;
            }
        }

        // Делегат для своего метода сортировик в QuestionsHandler \\
        public delegate void SortQuestionDelegate();

        // Класс-контейнер вопросов \\
        public class QuestionsHandler
        {
            // Поля \\
            protected List<Question> Questions = new List<Question>();
            protected SortQuestionDelegate Sort; // You can make your own method of sorting, you can sort by dificult and so on

            // Св-ва и индексаторы \\
            public int Length => Questions.Count;
            /// <summary>
            /// Отдаёт только пронусерованный текст вопросов
            /// </summary>
            public string GetOnlyText
            {
                get
                {
                    string output = "";
                    for (int i = 0; i < Length - 1; i++)
                    {
                        output += $"{i + 1}) " + Questions[i].GetText + $" (Сложность {Questions[i].GetDificulty})" + '\n';
                    }
                    output += $"{Length}) " + Questions[Length - 1].GetText + $" (Сложность {Questions[Length - 1].GetDificulty})";
                    return output;
                }
            }
            public Question this[int index]
            {
                get
                {
                    if (index < 0 || index >= Length)
                    {
                        throw new Exception("Индекс вне массива");
                    }
                    return Questions[index];
                }
            }

            // Конструкторы \\
            /// <summary>
            /// Создаёт непустой объект QuestionsHandler(без вопросов) с определённым методом сортировки MethodOfSorting
            /// </summary>
            /// <param name="ListWithQuestions"></param>
            /// <param name="MethodOfSorting"></param>
            public QuestionsHandler(List<Question> ListWithQuestions, SortQuestionDelegate MethodOfSorting = null)
            {
                Questions = ListWithQuestions;

                if (MethodOfSorting != null)
                {
                    Sort = MethodOfSorting;
                }
                else
                {
                    Sort = () => // BubbleSort For Default
                    {
                        for (int i = 0; i < Questions.Count - 1; i++)
                        {
                            for (int j = i + 1; j < Questions.Count; j++)
                            {
                                if (Questions[i].GetDificulty >= Questions[j].GetDificulty)
                                {
                                    var temp = Questions[i];
                                    Questions[i] = Questions[j];
                                    Questions[j] = temp;
                                }
                            }
                        }
                    };
                }
            }
            /// <summary>
            /// Создаёт пустой объект QuestionsHandler(без вопросов) с определённым методом сортировки MethodOfSorting
            /// </summary>
            /// <param name="MethodOfSorting"></param>
            public QuestionsHandler(SortQuestionDelegate MethodOfSorting = null)
            {
                if (MethodOfSorting != null)
                {
                    Sort = MethodOfSorting;
                }
                else
                {
                    Sort = () => // BubbleSort For Dafault
                    {
                        for (int i = 0; i < Questions.Count - 1; i++)
                        {
                            for (int j = i + 1; j < Questions.Count; j++)
                            {
                                if (Questions[i].GetDificulty <= Questions[j].GetDificulty)
                                {
                                    var temp = Questions[i];
                                    Questions[i] = Questions[j];
                                    Questions[j] = temp;
                                }
                            }
                        }
                    };
                }
            }

            // Методы \\
            /// <summary>
            /// Перемешивает вопросы
            /// </summary>
            public void ShakeQuestion()
            {
                Random rnd = new Random();
                for (int i = 0; i < Length; i++)
                {
                    int index = rnd.Next(i, Length);

                    Question temp = Questions[i];
                    Questions[i] = Questions[index];
                    Questions[index] = temp;
                }
            }
            /// <summary>
            /// Сортирует вопросы(в данном случае по сложности)
            /// </summary>
            public void SortForDificult() => Sort.Invoke();
            /// <summary>
            /// Считывает вопросы из файла по пути PathToFile
            /// </summary>
            /// <param name="PathToFile"></param>
            /// <returns></returns>
            public bool LoadFromFile(string PathToFile)
            {
                if (File.Exists(PathToFile))
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(PathToFile))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                string txt = line;
                                int dif = int.Parse(sr.ReadLine().Substring(10));
                                List<string> answers = new List<string>();
                                int answer = 0;
                                int i = 0;
                                while ((line = sr.ReadLine()) != "---")
                                {
                                    if (line.Contains("(*)"))
                                    {
                                        answer = i;
                                        line = line.Substring(0, line.Length - 3);
                                    }
                                    answers.Add(line);
                                    i++;
                                }

                                Question q = null;

                                if (answers.Count > 1) // create MultuQuestion
                                {
                                    q = new MultiQuestion(txt, answer, dif, answers);
                                }
                                else if (answers.Count == 1)// create Question
                                {
                                    q = new Question(txt, (answers[0] == "Да") ? (0) : (1), dif);
                                }

                                if (q != null) // Add question
                                {
                                    Questions.Add(q);
                                }
                            }
                        }
                    }
                    catch
                    {
                        throw new Exception("Файл не удолось считать");
                    }   
                }
                else
                {
                    return false;
                }
                return true;
            }

            /// <summary>
            /// Сохраняет данный контейнер вопросов в созданный файл по пути PathToDirectory с названием FileName 
            /// </summary>
            /// <param name="PathToFile"></param>
            /// <param name="FileName"></param>
            /// <returns></returns>
            public bool SaveToFile(string PathToDirectory, string FileName) 
            {
                // Если вопросов нет, то и сохранять нечего
                if (Length == 0) return false;

                // Если существует файл с заданным именем, то возвращаем false
                if (File.Exists(PathToDirectory + $"\\{FileName}.txt")) 
                {
                    return false;
                }
                else
                {
                    StreamWriter Sw = File.CreateText(PathToDirectory + $"\\{FileName}.txt");

                    for (int i = 0; i < Length; i++)
                    {
                        this[i].SaveIntoTxtFile(Sw);
                        Sw.WriteLine("---");
                    }

                    Sw.Close();
                }
                return true;
            }
        }

    }

    // Тут вспомогательнее классы для коректной работы форм
    namespace Managers
    {
        /// <summary>
        /// Класс-Конфигурации пока что бесполезен :(
        /// </summary>
        class Configuration
        {
            // Поля \\
            protected string PathToWithQuestions;
            protected string CurentDirectory;

            // Св-ва \\
            public string GetPathToWithQuestions => CurentDirectory + PathToWithQuestions;

            // Конструкторы \\
            public Configuration() 
            {
                CurentDirectory = Directory.GetCurrentDirectory();
            }

            // Методы \\
            /// <summary>
            /// Считывает конфигурацию из файла
            /// </summary>
            /// <param name="path"></param>
            /// <returns></returns>
            public bool LoadConfigFromFile(string path)
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        PathToWithQuestions =  "\\" + sr.ReadLine();
                    }
                    return true;
                }
                return false;
            }
            /// <summary>
            /// Сохраняет конфигурацию в файл
            /// </summary>
            /// <param name="path"></param>
            /// <returns></returns>
            public void SaveConfigToFile(string path) 
            {
                StreamWriter sw;

                if (File.Exists(path))
                {
                    sw = new StreamWriter(path);
                }
                else
                {
                    sw = File.CreateText(path);
                }

                sw.WriteLine($"PathToDirectory:{PathToWithQuestions}");
            }
        }

        // Класс, управляющий файлами приложения
        public class FilesManager
        {
            // Поля \\
            private string PathOfDirectory; // Путь к папке со всеми файлами вопросов
            private List<string> FilesNames = new List<string>();

            // Св-ва \\
            public int Length => FilesNames.Count;
            public string this[int index]
            {
                get 
                { 
                    if(index >= 0 && index < Length)
                        return FilesNames[index];
                    throw new IndexOutOfRangeException();
                }
            }

            // Конструкторы \\ 
            public FilesManager(string pathToDirectory)
            {
                if (Directory.Exists(pathToDirectory))
                {
                    PathOfDirectory = pathToDirectory;
                }
                else
                {
                    throw new Exception("Не существующий путь к папке");
                }
            }

            // Методы \\
            /// <summary>
            /// Сканирует директорию на файлы и добавляет имена текстовых файлов в лист
            /// Возвращает количество добавленных файлов
            /// </summary>
            /// <returns></returns>
            public int LoadFilesNames()
            {
                int Quantity = 0;
                var Files = Directory.GetFiles(PathOfDirectory);
                foreach (var item in Files)
                {
                    if(item.EndsWith(".txt"))
                    {
                        FilesNames.Add(item.Substring(item.LastIndexOf('\\') + 1, item.Length - 5 - item.LastIndexOf('\\')));
                    }
                }
                return Quantity;
            }

            public override string ToString()
            {
                string Ans = "";
                for (int i = 0; i < FilesNames.Count; i++)
                {
                    Ans += FilesNames.Count - 1 == i? (FilesNames[i]) : FilesNames[i] + '\n';
                }
                return Ans;
            }
        
            /// <summary>
            /// Возвращает полный путь к файлу по индексу
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            public string GetPathToChosenFile(int index) => PathOfDirectory + "\\" + FilesNames[index] + ".txt";
        }
    }

}


