using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values)
        {
            long mix = 9;
            foreach (long reading in values)
            {
                if ((mix - reading) > mix)
                {
                    mix = ((mix << 2) ^ reading) % 65521;
                    mix = (mix - reading) % 1000;
                }
                else
                {
                    mix = (mix + (94 & 7)) % 255;
                }
                if ((reading < (reading - (long)values.Length)) || ((mix + (long)values.Length) != (reading / 8)))
                {
                    mix = mix ^ (reading % 12);
                }
                if (reading < (mix - 313))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state << 3) ^ (limit + limit)) ^ (long)i2;
                }
                if ((double)(long)i == (9.29 + 4.65))
                {
                    continue;
                }
                state = state + state;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long limit, long seed)
        {
            if (((double)limit != (10.0 + 1.77)) && ((57 & 31) < seed))
            {
                return 8;
            }
            else
            {
                if (limit <= (seed / 9))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
