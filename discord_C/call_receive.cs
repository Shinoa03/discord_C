using System.Threading.Tasks;
using Discord.Commands;
using System;
using Discord;

namespace DiscordBot
{
    // 모듈 클래스의 접근제어자가 public이면서 ModuleBase를 상속해야 모듈이 인식된다.
    public class call_receive : ModuleBase<SocketCommandContext>
    {
        /// <summary>
        /// !hi 명령어를 입력했을 때 실행되는 함수
        /// </summary>
        [Command("hi")]
        public async Task HelloCommand()
        {
            //ModuleBase를 상속하면 Context 변수를 통해 답장을 보낼 수 있다. 
            await Context.Channel.SendMessageAsync("Hello World!");
        }

        [Command("칸나야")]
        public async Task joke()
        {
            string A = "";
            Random joke_1 = new Random();
            int joke_switch = joke_1.Next(1, 6);//1에서 6 미만
            switch(joke_switch)
            {
                case 1:
                    A = "넹~";
                    break;
                case 2:
                    A = "네..?";
                    break;
                case 3:
                    A = "칸나 여기 있어요!";

                    break;
                case 4:
                    A = "네에에~";
                    break;
                case 5:
                    A = "씨발!";
                    break;
                default:
                    break;
            }
            await Context.Channel.SendMessageAsync(A);

        }

        [Command("간나야")]
        public async Task Ganna()
        {

            EmbedBuilder eb = new EmbedBuilder(); //eb 임배드

            //Embed 메시지의 속성 설정
            eb.Color = Color.Red;          // 메시지의 색을 파란색으로 설정
            eb.Title = "간나 뜻";          //Embed의 제목
            eb.Description = "칸나의 이름은 칸나에요.";    //Embed의 설명
            eb.AddField("간나 [명사][방언]", "'계집아이'의 방언(평북,함경)");      //필드 선언
            await Context.Channel.SendMessageAsync("", false, eb.Build());  //Embed를 빌드하여 메시지 전송

        }
        [Command("ㅋㄴㅇ")]
        public async Task Chosung()
        {
            string A = "";
            Random joke_1 = new Random();
            int joke_switch = joke_1.Next(1, 4);//1에서 4 미만
            switch (joke_switch)
            {
                case 1:
                    A = "ㅇ";
                    break;
                case 2:
                    A = "?";
                    break;
                case 3:
                    A = "ㅁ";
                    break;
                default:
                    break;
            }
            await Context.Channel.SendMessageAsync(A);
        }

        [Command("임배드예시")]
        public async Task EmbedEx()
        {
            await Context.Channel.SendMessageAsync("Hello World!");

                       //Embed 메시지를 생성할 빌더 인스턴스 생성 
            EmbedBuilder eb = new EmbedBuilder(); //eb 임배드
            
                       //Embed 메시지의 속성 설정
            eb.Color = Color.Blue;          // 메시지의 색을 파란색으로 설정
            eb.Title = "Embed 제목";          //Embed의 제목
            eb.Description = "Embed 설명";    //Embed의 설명
            eb.AddField("필드 1", "필드 1 값");      //필드 선언
            eb.AddField("인라인 필드 1", "인라인 필드 1 값", true);    //인라인 필드 선언
            eb.AddField("인라인 필드 2", "인라인 필드 2 값", true);    //인라인 필드 선언
            
            await Context.Channel.SendMessageAsync("", false, eb.Build());  //Embed를 빌드하여 메시지 전송
        }




    }
}