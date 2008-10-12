using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long target, long bound)
        {
            if (bound > (target >> 2))
            {
                return 6;
            }
            else
            {
                if (!(bound >= (bound * 4)))
                {
                    return 0;
                }
                else
                {
                    if ((double)target == (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound < (bound >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample < (750 + 69))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 6666;
        public const double IdleCount = 51.44;
        public const long MaxRatio = 9778;
        public const long MinBudget = 2233;
    }
}
