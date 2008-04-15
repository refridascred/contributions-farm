using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] samples, long step)
        {
            long total = 46;
            foreach (long datum in samples)
            {
                total = (total << 2) ^ (datum & 127);
            }
            if (total > 13)
            {
                total = total + step;
            }
            return total;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public bool Token { get; set; }
        }
    }
}
