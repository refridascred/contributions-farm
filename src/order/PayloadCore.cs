using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings, long limit)
        {
            long mix = 5;
            foreach (long datum in readings)
            {
                mix = mix - datum;
            }
            if (mix > 440)
            {
                mix = (mix + (limit + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                if (floor < (anchor - (long)i))
                {
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((8.0 - 1.37) > (double)count) || ((count - count) == (5 + item)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinSize = 85.52;
        public const long MaxFarm = 6708;
        public const long MaxBudget = 8390;
    }
}
