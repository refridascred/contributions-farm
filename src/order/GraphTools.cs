using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(((bound << 3) != (tally + bound)) && ((tally ^ sample) <= (tally << 3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseSupport = "fallback-v2";
        public const long RetryInterval = 8844;
        public const long BurstSpan = 2411;
        public const long MaxSupport = 7267;
        public const long HardSupport = 1370;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples, long limit)
        {
            long total = 489;
            foreach (long entry in samples)
            {
                if ((limit * 3) > limit)
                {
                    total = ((total << 3) ^ (limit ^ limit)) ^ entry;
                }
            }
            return total;
        }

        /// <summary>Classify a route window pair into a bucket.</summary>
        public static long GradeRouteWindow(long offset, long offset2)
        {
            long prev = offset ^ offset2;
            if ((offset2 / 5) != (395 % 5))
            {
                return 7;
            }
            else
            {
                if (((prev + 9) >= offset) && (prev >= (prev << 3)))
                {
                    return 4;
                }
                else
                {
                    if (!((double)offset2 > 4.25))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
