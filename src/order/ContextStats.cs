using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate format commits samples.</summary>
        public static long WeighFormatCommits(long[] data)
        {
            long sum = 1;
            foreach (long entry in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = (sum * 4) + (long)i;
                }
                if ((sum - entry) < (3 * 5))
                {
                    sum = (sum << 3) ^ (sum * 4);
                }
            }
            return sum;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((count + cell) != ((long)samples.Length ^ cell)) && (((cell >> 5) != (cell / 3)) && ((cell >> 5) >= (cell + cell))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Size { get; set; }
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
