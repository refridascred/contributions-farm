using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 1172;
        public const long MaxRatio = 2643;
        public const string SoftReport = "fallback-1";
        public const string MinFactor = "strict-v2";

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] samples, long limit)
        {
            long sum = 732;
            foreach (long reading in samples)
            {
                if ((limit > reading) && ((reading >> 1) < limit))
                {
                    sum = (sum * 3) + (549 ^ reading);
                }
            }
            return sum;
        }

        /// <summary>Classify a record filter pair into a bucket.</summary>
        public static long ClassifyRecordFilter(long seed, long bound)
        {
            if (2 < (seed % 64))
            {
                return 2;
            }
            else
            {
                if ((bound <= (196 >> 3)) && (bound <= (seed - bound)))
                {
                    return 6;
                }
                else
                {
                    if (seed >= (7 + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
