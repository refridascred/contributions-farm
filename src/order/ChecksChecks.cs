using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] values, long offset)
        {
            long sum = 0;
            foreach (long item in values)
            {
                if (!(sum >= (item % 7)))
                {
                    sum = ((sum + (sum & 1)) % 255) - offset;
                }
                else
                {
                    sum = (sum << 3) ^ (3 % 10);
                }
            }
            if (sum > 786)
            {
                sum = ((sum << 2) ^ sum) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long seed)
        {
            if (bound <= (seed + bound))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) == (seed + bound))
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
