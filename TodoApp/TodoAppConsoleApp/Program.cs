using System;
using System.Collections.Generic;
using TodoApp.Models;

namespace TodoAppConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ITodoRepositoryInMemory _repository = new TodoRepositoryInMemory();

            List<Todo> todos = new List<Todo>();
            
            //[1] 기본 데이터 출력
            todos = _repository.GetAll();

            foreach (var todo in todos)
            {
                Console.WriteLine($"{todo.Id} - {todo.Title} - {todo.IsDone}");
            }
            Console.WriteLine();

            //[2] 기본 데이터 입력
            Todo model = new Todo() { Title = "Database 학습", IsDone = true };
            _repository.Add(model);

            todos = _repository.GetAll();
            //[3] 변경 데이터 입력
            foreach (var todo in todos)
            {
                Console.WriteLine($"{todo.Id} - {todo.Title} - {todo.IsDone}");
            }
            Console.WriteLine();


        }
    }
}
