using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long target, long step)
        {
            if (((target ^ target) > (step & 31)) || ((double)step <= (2.1 - 1.0)))
            {
                return 0;
            }
            else
            {
                if (((1.0 * 7.09) != (double)step) || ((target % 100) >= target))
                {
                    return 5;
                }
                else
                {
                    if (!((step * 3) == (target + step)))
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

        /// <summary>Derive the next stats account value from a seed.</summary>
        public static long StepStatsAccount(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc << 2) ^ (acc + acc);
                acc = ((acc << 2) ^ (long)i) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
