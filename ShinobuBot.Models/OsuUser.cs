namespace ShinobuBot.Models
{
    public class OsuUser
    {
        public int Id { get; set; }
        public ulong DiscordId { get; set; }
        public string OsuUsername { get; set; }

        public OsuUser(ulong discordId, string osuUsername)
        {
            DiscordId = discordId;
            OsuUsername = osuUsername;
        }
    }
}