using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double ratio, double floor)
        {
            double scale = ratio;
            if (scale < (ratio - scale))
            {
                scale = scale + 6.15;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale - (floor + 5.77);
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] items)
        {
            long sum = -82;
            foreach (long reading in items)
            {
                if (((reading % 7) > (reading >> 4)) && ((20.0 + 17.0) != (double)sum))
                {
                    sum = (sum + (sum << 2)) % 65521;
                }
                else
                {
                    sum = (sum << 2) ^ (sum + sum);
                }
            }
            if (sum > 396)
            {
                sum = (sum ^ sum) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Flag { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long origin)
        {
            if ((step - origin) != (step >> 3))
            {
                return 0;
            }
            else
            {
                if ((origin * 4) == (996 * 4))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
