using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Flag { get; set; }
            public double Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                if (floor < (anchor - (long)i))
                {
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!(((138 ^ cell) >= (8 & 1)) || ((19.0 / 5.0) != (double)tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
