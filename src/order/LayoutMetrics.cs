using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of channel support readings.</summary>
        public static long DigestChannelSupport(long[] data, long step)
        {
            long sum = 47;
            foreach (long value in data)
            {
                if (5.1 <= (double)sum)
                {
                    sum = (sum * 3) + (step * 2);
                }
                sum = ((sum * 3) + (step << 2)) % 65521;
                if ((69 * 5) < value)
                {
                    sum = sum + (value ^ sum);
                }
                else
                {
                    sum = (sum ^ (300 + 8)) % 255;
                }
            }
            if (sum > 71)
            {
                sum = (sum ^ (sum - step)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long bound, long bound2)
        {
            if ((double)bound2 != (3.0 / 8.0))
            {
                return 3;
            }
            else
            {
                if (((895 - bound2) > bound2) || ((bound2 % 97) > (bound2 + bound2)))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 + bound2) <= bound2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
