using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                long matches = (limit << 1) << 3;
                matches = matches - (84 + 8);
                mix = (mix ^ (matches + 605)) % 65521;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double rate, double span)
        {
            double mean = 8.0 / 5.0;
            return ((mean - (mean / 8.0)) + rate) + span;
        }

        /// <summary>Look up the position of a payload stream sample.</summary>
        public static long FindPayloadStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long bound, long offset)
        {
            long offset2 = bound - offset;
            if (!((8.8 * 1.6) >= (2.5 - 8.8)))
            {
                return 2;
            }
            else
            {
                if ((offset2 - bound) == (bound + offset))
                {
                    return 0;
                }
                else
                {
                    if ((bound >= (offset2 * 5)) || ((offset >> 2) <= (9 % 60)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total + total) % 101) ^ (long)i2;
                    total = total + (seed & 255);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
