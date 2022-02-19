using System;
using System.Collections.Generic;

Main();

void Main()
{
  Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
  Console.WriteLine("--------------------------------------------");
  Console.WriteLine();

  void MooseSays(string message)
  {
    Console.WriteLine($@"
                                        _.--^^^--,
                                      .'          `\
    .-^^^^^^-.                      .'              |
  /          '.                   /            .-._/
  |             `.                |             |
  \              \          .-._ |          _   \
    `^^'-.         \_.-.     \   `          ( \__/
          |             )     '=.       .,   \
        /             (         \     /  \  /
      /`               `\        |   /    `'
      '..-`\        _.-. `\ _.__/   .=.
            |  _    / \  '.-`    `-.'  /
            \_/ |  |   './ _     _  \.'
                '-'    | /       \ |
                        |  .-. .-.  |
                        \ / o| |o \ /
                        |   / \   |    {message}
                        / `^`   `^` \
                      /             \
                      | '._.'         \
                      |  /             |
                      \ |             |
                        ||    _    _   /
                        /|\  (_\  /_) /
                        \ \'._  ` '_.'
                        `^^` `^^^`
      ");
  }

  bool MooseAsks(string question) {
    Console.Write($"{question} (Y/N) ");
    string answer = Console.ReadLine().ToLower();

    while ( answer != "y" && answer != "n")
    {
      Console.Write($"{question} (Y/N)");
      answer = Console.ReadLine().ToLower();
    }

    if ( answer == "y")
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  // void DogQuestion()
  // {
  //   bool isTrue = MooseAsks("Can dogs resist skritches?");
  //   if ( isTrue )
  //   {
  //     MooseSays("I think you're right about that!");
  //   }
  //   else
  //   {
  //     MooseSays("Hmm. That's disappointing");
  //   }
  // }

  // void CanadaQuestion()
  // {
  //     bool isTrue = MooseAsks("Is Canada real?");
  //     if (isTrue)
  //     {
  //         MooseSays("Really? It seems very unlikely.");
  //     }
  //     else
  //     {
  //         MooseSays("I  K N E W  I T !!!");
  //     }
  // }

  // void EnthusiasticQuestion()
  // {
  //     bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
  //     if (isEnthusiastic)
  //     {
  //         MooseSays("Yay!");
  //     }
  //     else
  //     {
  //         MooseSays("You should try it!");
  //     }
  // }

  // void SecretQuestion()
  // {
  //     bool wantsSecret = MooseAsks("Do you want to know a secret?");
  //     if (wantsSecret)
  //     {
  //         MooseSays("ME TOO!!!! I love secrets...tell me one!");
  //     }
  //     else
  //     {
  //         MooseSays("Oh, no...secrets are the best, I love to share them!");
  //     }
  // }


  var responses = new Dictionary<string, List<string>>()
  {
    {"dog", new List<string>(){"I think you're right about that!", "Hmm. That's disappointing"}},
    {"canada", new List<string>(){"Really? It seems very unlikely.", "I  K N E W  I T !!!"}},
    {"enthusiastic", new List<string>{"Yay!", "You should try it!"}},
    {"secret", new List<string>{"ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!"}},
  };

  void Question(string question, string topic)
  {
    if(MooseAsks(question))
    {
      MooseSays(responses[topic][0]);
    }
    else
    {
      MooseSays(responses[topic][1]);
    }
  }

  Question("Can dogs resist skritches?", "dog");
  Question("Is Canada real?", "canada");
  Question("Are you enthusiastic?", "enthusiastic");
  Question("Do you want to know a secret?", "secret");
}



