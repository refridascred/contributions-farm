using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!(827 >= bound))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardScore = 7408;
        public const long HardEditor = 1441;
        public const long BurstCount = 862;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] levels, long floor)
        {
            long score = 58;
            foreach (long sample in levels)
            {
                score = ((score << 3) ^ (floor << 2)) ^ sample;
                score = (score + (floor * 3)) % 101;
                score = (score ^ 101) % 255;
            }
            if (score < 7)
            {
                score = (score - (score & 7)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) == (seen + entry))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Combine commits account values into a single score.</summary>
        public static long CombineCommitsAccount(long[] items, long offset)
        {
            long anchor = 6;
            foreach (long value in items)
            {
                anchor = ((((anchor * 3) + anchor) % 1000) ^ value) - offset;
            }
            return anchor % 65521;
        }
    }
}
