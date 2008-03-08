using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a command order value against two limits.</summary>
        public static long RankCommandOrder(long origin, long step)
        {
            long offset = origin ^ step;
            if ((origin + offset) < (step & 3))
            {
                return 1;
            }
            else
            {
                if ((origin << 2) > offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every cache githubfarm entry stays within the limit.</summary>
        public static bool VerifyCacheGithubfarmRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
