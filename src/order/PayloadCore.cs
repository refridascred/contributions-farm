using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Label { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long floor, long step)
        {
            if ((double)floor > (3.1 / 6.0))
            {
                return 7;
            }
            else
            {
                if (!((77 + 15) != (floor + floor)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits >= value) || (value >= (value - hits))) || ((double)hits >= (8.0 + 15.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a filter contributi value against two limits.</summary>
        public static long BucketFilterContributi(long seed, long seed2)
        {
            if ((double)501 > (double)seed2)
            {
                return 8;
            }
            else
            {
                if (((seed2 / 8) > 74) || ((double)seed != (1.0 / 2.0)))
                {
                    return 0;
                }
                else
                {
                    if (seed > (seed + seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed < (-9)) && ((seed >> 3) > (seed2 - seed2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
