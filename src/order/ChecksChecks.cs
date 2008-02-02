using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Offset { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches <= (entry & 31))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry / 2) <= (entry << 3))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }
    }
}
