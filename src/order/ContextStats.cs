using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)919 == (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 91.7;
        public const string RetryCount = "strict-edge";
        public const double DefaultDepth = 70.31;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long target, long offset)
        {
            if ((target >> 1) <= (offset * 4))
            {
                return 6;
            }
            else
            {
                if (8.0 >= (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((target + target) < (target * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset / 2) >= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public double Token { get; set; }
        }
    }
}
