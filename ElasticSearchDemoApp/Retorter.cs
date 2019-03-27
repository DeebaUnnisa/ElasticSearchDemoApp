using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.NLP.Models;

namespace ElasticSearchDemoApp
{
    public class Retorter
    {
        public IList<string> Retorts { get; private set; }

        private IList<string> greetings = new List<string>()
        {
            //"Hi! I'm 1S.AI, how are you?",
            //"Hello there! I'm called 1S.AI, what's your name?",
            "Hello Sai, how may I help you?",
        };

        private IList<string> randresp = new List<string>()
        {
            "I'll take that under advisement",
            "I'm feeling sad!",
            "I'll get back to you on that",
            "I don't know what to say!",
        };

        private IList<string> byelist = new List<string>()
        {
            "What going already?",
            "Bye! I'll miss you!",
        };


        private Random random = new Random();

        public Retorter(NlpParsedResult nlpParsedResult)
        {
            Retorts = new List<string>();
            GenerateHumor(nlpParsedResult);
        }

        private void GenerateHumor(NlpParsedResult nlpParsedResult)
        {
            foreach (var sentence in nlpParsedResult.NlpSentences)
            {
                ProcessTokens(sentence);
            }
        }

        private void ProcessTokens(NlpSentence sentence)
        {
            bool responded = false;
            bool ask = false;

            foreach (var token in sentence.NlpTokens)
            {
                if (token.PartOfSpeech == POS.UH && !responded)
                {
                    responded = true;
                    Retorts.Add(GetRandomGreeting());
                }

                if (token.PartOfSpeech == POS.WP && token.Text.Trim() == "what")
                {
                    ask = true;
                }

                if (token.PartOfSpeech == POS.WRB && token.Text.Trim() == "where" ||
                    token.PartOfSpeech == POS.VB && token.Text.Trim() == "tell")
                {
                    ask = true;
                }

                if (ask && !responded)
                {
                    if (token.Text.Trim() == "time")
                    {
                        responded = true;
                        Retorts.Add("The time is " + DateTime.Now.ToString("h:mm tt") + " where I live.");
                    }
                    if (token.Text.Trim() == "name")
                    {
                        responded = true;
                        Retorts.Add(GetRandomGreeting());
                    }
                    if (token.Text.Trim() == "live")
                    {
                        responded = true;
                        Retorts.Add("I live somewhere near Minneapolis, I cannot give out my exact location due to privacy laws :-D");
                    }
                    if (token.Text.Trim() == "weather")
                    {
                        responded = true;
                        Retorts.Add("It's sunny and 75 degrees F, at least I hope it is somewhere!");
                    }
                }

                if (!responded)
                {
                    if (token.Text.Trim() == "dumb" ||
                        token.Text.Trim() == "moron" ||
                        token.Text.Trim() == "idiot" ||
                        token.Text.Trim() == "idiotic" ||
                        token.Text.Trim() == "stupid")
                    {
                        Retorts.Add(GetRandomResponse());
                    }
                }

                if (!responded)
                {
                    if (token.Text.Trim() == "bye" ||
                        token.Text.Trim() == "goodbye")
                    {
                        Retorts.Add(GetByeResp());
                    }
                }
            }
        }

        private string GetRandomGreeting()
        {
            int r = random.Next(greetings.Count);
            return greetings[r];
        }

        private string GetRandomResponse()
        {
            int r = random.Next(randresp.Count);
            return randresp[r];
        }

        private string GetByeResp()
        {
            int r = random.Next(byelist.Count);
            return byelist[r];
        }
    }
}
