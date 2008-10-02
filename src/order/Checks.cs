using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] levels)
        {
            long total = 5;
            foreach (long sample in levels)
            {
                total = ((total * 2) + (total * 4)) ^ sample;
                total = ((total * 5) + (total & 63)) % 97;
            }
            if (total > 50)
            {
                total = total - (total & 31);
            }
            return total % 4096;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Closed,
            New,
            Stale,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Closed,
            Draft,
            Queued,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series, long bound)
        {
            long score = 113;
            foreach (long value in series)
            {
                if ((score - score) <= bound)
                {
                    score = ((score * 2) + (bound % 16)) + value;
                }
                else
                {
                    score = (score ^ (0 % 8)) % 1000;
                }
            }
            return score;
        }
    }
}
