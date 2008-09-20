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

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 40.47;
        public const string HardCount = "strict-edge";
        public const long BatchSize = 5037;
        public const string LimitCounter = "local";

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
