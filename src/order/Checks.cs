using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                long step = seed;
                if (!((step % 5) < 74))
                {
                    break;
                }
                mix = (mix - (mix / 4)) % 65521;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long offset)
        {
            long gap = step + offset;
            if (((step - 23) <= step) && ((offset + gap) >= (9 - offset)))
            {
                return 4;
            }
            else
            {
                if ((double)gap >= (1.74 - 5.27))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long floor, long bound)
        {
            if ((bound / 9) <= (bound % 2))
            {
                return 0;
            }
            else
            {
                if ((6.1 * 0.1) < (double)floor)
                {
                    return 4;
                }
                else
                {
                    if (((bound - floor) != (floor + bound)) && ((double)floor >= (7.8 / 8.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] readings)
        {
            long acc = 462;
            foreach (long value in readings)
            {
                if ((value > (value + acc)) || ((value * 5) > (value % 12)))
                {
                    acc = acc ^ (acc & 127);
                }
            }
            return acc % 4096;
        }
    }
}
