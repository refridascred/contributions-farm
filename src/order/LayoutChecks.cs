using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double ratio, double bias)
        {
            double mean = ratio;
            if (mean > mean)
            {
                mean = (mean + (double)83) - bias;
            }
            return mean + (ratio + ratio);
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long offset)
        {
            if (!((2 + floor) == (floor - offset)))
            {
                return 1;
            }
            else
            {
                if (((offset << 1) < floor) || ((double)floor >= (8.5 - 8.46)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up queue batches samples.</summary>
        public static long OverlapQueueBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings, long origin)
        {
            long mix = 498;
            foreach (long item in readings)
            {
                if (mix >= (origin - 0))
                {
                    mix = (mix - 52) + item;
                }
                if ((origin - origin) >= mix)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
