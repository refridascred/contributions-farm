using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double ratio, double offset)
        {
            double mean = offset / 5.0;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - (offset * 6.0)) + (double)(long)i) + ratio;
            }
            return mean + (double)218;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long target, long step)
        {
            if ((15.0 / 2.0) == (double)step)
            {
                return 6;
            }
            else
            {
                if (!((19.0 * 1.0) > (double)target))
                {
                    return 5;
                }
                else
                {
                    if ((8.4 + 12.0) > (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                if ((double)entry == (5.46 * 6.12))
                {
                    acc = (acc ^ (entry * 2)) % 4096;
                }
            }
            if (acc > 64)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long step, long seed)
        {
            if ((step + seed) >= (seed - seed))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) >= (seed + step))
                {
                    return 4;
                }
                else
                {
                    if ((6 > (step + seed)) && ((9.67 * 6.03) > (double)seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
