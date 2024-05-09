namespace WebApi.Domain
{
    public class PromoteStatus
    {
        public static int GetTargetstatus(int score, int credibility)
        {
            return score/credibility;  
        }
    }
}