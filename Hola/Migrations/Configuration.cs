namespace Hola.Migrations
{
    using Hola.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Hola.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Hola.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
      
            #region Adding Languages
            context.Languages.AddOrUpdate(l => l.LanguageID,
                new Language
                {
                    LanguageID = 1,
                    Name = "French",
                    Icon = "Graphics/Languages/French/frenchIcon.png"
                },
                new Language
                {
                    LanguageID = 2,
                    Name = "German",
                    Icon = "Graphics/Languages/German/germanIcon.png"
                },
                new Language
                {
                    LanguageID = 3,
                    Name = "Japanese",
                    Icon = "Graphics/Languages/Japanese/japaneseIcon.png"
                },
                new Language
                {
                    LanguageID = 4,
                    Name = "Spanish",
                    Icon = "Graphics/Languages/Spanish/spanishIcon.png"
                },
                new Language
                {
                    LanguageID = 5,
                    Name = "Chinese",
                    Icon = "Graphics/Languages/Chinese/ChineseIcon.png"
                }
             );

            #endregion

            #region Adding Words
            context.Words.AddOrUpdate(

            #region FrenchWords

                #region Level-01
                new Word
                {
                    LanguageID = 1,
                    Level = 1,
                    WordID = 1,
                    WordText = "Bienvenue!",
                    WordEnglish = "Welcome!",
                    ImagePath = "Graphics/Languages/French/Level-01/01-Welcome.jpg",
                    VoicePath = "Audio/French/Level-01/01-Bienvenue.mp3"
                },
                new Word
                {
                    LanguageID = 1,
                    Level = 1,
                    WordID = 2,
                    WordText = "Bonjour!",
                    WordEnglish = "Hello!",
                    ImagePath = "Graphics/Languages/French/Level-01/02-Hello.jpg",
                    VoicePath = "Audio/French/Level-01/02-Bonjour!.mp3"
                },
                new Word
                {
                    LanguageID = 1,
                    Level = 1,
                    WordID = 3,
                    WordText = "Bonsoir!",
                    WordEnglish = "Good evening!",
                    ImagePath = "Graphics/Languages/French/Level-01/03-Good evening.jpg",
                    VoicePath = "Audio/French/Level-01/03-Bonsoir!.mp3"
                },
                new Word
                {
                    LanguageID = 1,
                    Level = 1,
                    WordID = 4,
                    WordText = "Merci",
                    WordEnglish = "Thanks",
                    ImagePath = "Graphics/Languages/French/Level-01/04-Thanks.jpg",
                    VoicePath = "Audio/French/Level-01/04-Thanks.mp3"
                },
                new Word
                {
                    LanguageID = 1,
                    Level = 1,
                    WordID = 5,
                    WordText = "Comment tu t'appelles ?",
                    WordEnglish = "What's your name ?",
                    ImagePath = "Graphics/Languages/French/Level-01/05-What's your name.jpg",
                    VoicePath = "Audio/French/Level-01/05-What's your name.mp3"
                },
                new Word
                {
                    LanguageID = 1,
                    Level = 1,
                    WordID = 6,
                    WordText = "Je suis Marie.",
                    WordEnglish = "I am Marie",
                    ImagePath = "Graphics/Languages/French/Level-01/06-I am Marie.jpg",
                    VoicePath = "Audio/French/Level-01/06-I am Marie.mp3"
                },
                new Word
                {
                    LanguageID = 1,
                    Level = 1,
                    WordID = 7,
                    WordText = "Ça va ?",
                    WordEnglish = "How are you ?",
                    ImagePath = "Graphics/Languages/French/Level-01/07-How are you.jpg",
                    VoicePath = "Audio/French/Level-01/07-How are you.mp3"
                },
                new Word
                {
                    LanguageID = 1,
                    Level = 1,
                    WordID = 8,
                    WordText = "Bien, merci.",
                    WordEnglish = "Fine, thanks",
                    ImagePath = "Graphics/Languages/French/Level-01/08-Fine, thanks.jpg",
                    VoicePath = "Audio/French/Level-01/08-Fine, thanks.mp3"
                },

                #endregion

                #region Level-02
                new Word
                {
                    LanguageID = 1,
                    Level = 2,
                    WordID = 1,
                    WordText = "A quelle heure",
                    WordEnglish = "At what time",
                    ImagePath = "Graphics/Languages/French/Level-02/01-At what time.jpg",
                    VoicePath = "Audio/French/Level-02/01-At what time.mp3"
                },
                new Word
                {
                    LanguageID = 1,
                    Level = 2,
                    WordID = 2,
                    WordText = "On ouvre à neuf heures.",
                    WordEnglish = "We open at 9 o'clock",
                    ImagePath = "Graphics/Languages/French/Level-02/02-We open at 9 o'clock.jpg",
                    VoicePath = "Audio/French/Level-02/02-We open at 9 o'clock.mp3"
                },
                new Word
                {
                    LanguageID = 1,
                    Level = 2,
                    WordID = 3,
                    WordText = "À trois heures de l'après-midi ?",
                    WordEnglish = "At three o'clock in the afternoon?",
                    ImagePath = "Graphics/Languages/French/Level-02/03-At 3 in the afternoon.jpg",
                    VoicePath = "Audio/French/Level-02/03-At 3 in the afternoon.mp3"
                },
                new Word
                {
                    LanguageID = 1,
                    Level = 2,
                    WordID = 4,
                    WordText = "Bonne journée !",
                    WordEnglish = "Have a good day !",
                    ImagePath = "Graphics/Languages/French/Level-02/04-Good day!.jpg",
                    VoicePath = "Audio/French/Level-02/004-Good day!.mp3"
                },
                #endregion

                #endregion

                #region GermanWords

                    #region Level-01
                    new Word
                    {
                        LanguageID = 2,
                        Level = 1,
                        WordID = 1,
                        WordText = "Hallo!",
                        WordEnglish = "Hello!",
                        ImagePath = "Graphics/Languages/German/Level-01/01-Hello.jpg",
                        VoicePath = "Audio/French/Level-01/01-Hello.mp3"
                    }
                    #endregion

                    #endregion
                    #region JapaneseWords

                    #endregion
                    #region SpanishWords

                    #endregion
                    #region ChineseWords

                    #endregion

            );
            #endregion

            #region Adding Questinos
            context.Questions.AddOrUpdate(

            #region French

                #region Level-01

                new Question
                {
                    LanguageID = 1,
                    Level = 1,
                    QuestionID = 1,
                    QuestionText = "1. Puis-je vous ............ Madame Guibert ?",
                    QuestionEnglish = "May I ............ Mrs. Guibert?",
                    QuestionImagePath = "",
                    QuestionVoicePath = "Audio/French/[Questions]/01-01.mp3",
                    CorrectAnswer = "(c) présenter",
                    ChoiceA = "(a) introduire",
                    ChoiceB = "(b) prévenir",
                    ChoiceC = "(c) présenter",
                    ChoiceD  = "(d) proposer"
                },

                new Question
                {
                    LanguageID = 1,
                    Level = 1,
                    QuestionID = 2,
                    QuestionText = "2. Je ne connais ............ dans cette ville.",
                    QuestionEnglish = "I do not know ............ in this city.",
                    QuestionImagePath = "",
                    QuestionVoicePath = "Audio/French/[Questions]/01-02.mp3",
                    CorrectAnswer = "(d) pas",
                    ChoiceA = "(a) personne",
                    ChoiceB = "(b) rien",
                    ChoiceC = "(c) quelqu’un",
                    ChoiceD  = "(d) pas"
                },
                new Question
                {
                    LanguageID = 1,
                    Level = 1,
                    QuestionID = 3,
                    QuestionText = "3. Les personnes âgées aiment ............ du temps.",
                    QuestionEnglish = "Older people love ............ time.",
                    QuestionImagePath = "",
                    QuestionVoicePath = "Audio/French/[Questions]/01-03.mp3",
                    CorrectAnswer = "(c) parlez",
                    ChoiceA = "(a) parler",
                    ChoiceB = "(b) parlé",
                    ChoiceC = "(c) parlez",
                    ChoiceD  = "(d) parlés"
                },
                new Question
                {
                    LanguageID = 1,
                    Level = 1,
                    QuestionID = 4,
                    QuestionText = "4. Je suis fou ............ sport.",
                    QuestionEnglish = "I am crazy ............ sport.",
                    QuestionImagePath = "",
                    QuestionVoicePath = "Audio/French/[Questions]/01-04.mp3",
                    CorrectAnswer = "(d) de la",
                    ChoiceA = "(a) des",
                    ChoiceB = "(b) de",
                    ChoiceC = "(c) du",
                    ChoiceD  = "(d) de la"
                },
                new Question
                {
                    LanguageID = 1,
                    Level = 1,
                    QuestionID = 5,
                    QuestionText = "5. Je ne mange ............ viande.",
                    QuestionEnglish = "I do not eat ............ meat.",
                    QuestionImagePath = "",
                    QuestionVoicePath = "Audio/French/[Questions]/01-05.mp3",
                    CorrectAnswer = "(b) pas le",
                    ChoiceA = "(a) rien de",
                    ChoiceB = "(b) pas le",
                    ChoiceC = "(c) que de",
                    ChoiceD  = "(d) jamais de"
                }

                #endregion

                #endregion

                #endregion
            );
            context.SaveChanges();
        }
    }
}
