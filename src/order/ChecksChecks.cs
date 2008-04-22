using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 2178;
        public const long WindowAccount = 2734;
        public const long LimitAccount = 3992;
        public const long SoftAccount = 8724;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long bound, long target)
        {
            if (bound <= (bound % 24))
            {
                return 5;
            }
            else
            {
                if ((double)target == (5.4 - 8.9))
                {
                    return 6;
                }
                else
                {
                    if (!(target <= (target ^ target)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
