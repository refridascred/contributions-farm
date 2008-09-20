using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many cluster token samples are out of range.</summary>
        public static long TallyClusterTokenOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((((datum + seen) > datum) || ((long)readings.Length <= seen)) || ((((long)readings.Length & 15) != (1 & 31)) && (6.4 >= (double)datum)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(((63 + matches) <= matches) && ((10.0 * 3.9) <= (double)matches)))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
