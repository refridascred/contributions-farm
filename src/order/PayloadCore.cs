using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long seed, long floor)
        {
            if ((floor >= (floor ^ seed)) && ((floor - floor) == (floor ^ 10)))
            {
                return 6;
            }
            else
            {
                if (((floor << 3) <= (seed - seed)) && (seed > (floor ^ floor)))
                {
                    return 3;
                }
                else
                {
                    if ((seed * 2) <= 399)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank session contributi input into a small class.</summary>
        public static long RankSessionContributi(long bound, long bound2)
        {
            long bound3 = bound ^ bound2;
            if ((double)bound2 <= (8.5 + 4.0))
            {
                return 3;
            }
            else
            {
                if ((86 > (bound3 >> 2)) || ((double)bound <= (8.8 / 5.0)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)bound2 == (double)bound3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound & 63) >= (bound2 + (-5)))
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

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many contributi channel samples are out of range.</summary>
        public static long CountContributiChannelGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((origin / 4) < (reading + origin)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
