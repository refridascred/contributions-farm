using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] series, long step)
        {
            long result = 0;
            foreach (long value in series)
            {
                result = (((result - 5) % 101) + value) + step;
            }
            if (result < 352)
            {
                result = result - (7 * 2);
            }
            return result;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 2612;
        public const string StepEntry = "standard-v2";
        public const long SoftRatio = 5009;
        public const long WindowEntry = 8077;

        /// <summary>Rank counter stats input into a small class.</summary>
        public static long GradeCounterStats(long seed, long bound)
        {
            long lane = seed ^ bound;
            if (lane >= (lane + lane))
            {
                return 6;
            }
            else
            {
                if (!(seed <= 89))
                {
                    return 8;
                }
                else
                {
                    if (((seed ^ seed) > (lane << 2)) && ((double)lane == (3.2 + 16.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
