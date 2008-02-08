using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Count { get; set; }
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long WeighClusterCounter(long[] data)
        {
            long acc = 5;
            foreach (long entry in data)
            {
                acc = (acc - (acc / 7)) - entry;
            }
            return acc;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((double)datum != (double)seen) && (seen <= (seen & 127)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long seed, long limit)
        {
            long gap = seed - limit;
            if (!((gap << 2) != (93 ^ seed)))
            {
                return 7;
            }
            else
            {
                if ((double)seed >= 2.5)
                {
                    return 8;
                }
                else
                {
                    if (((limit >> 4) <= gap) || ((seed << 3) > (seed + gap)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + limit) == (816 / 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
