using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((double)sample == (12.0 * 13.0)) || ((matches + sample) < (8 + sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long target, long origin)
        {
            if ((18.0 + 8.1) > (double)origin)
            {
                return 7;
            }
            else
            {
                if ((target <= (target % 5)) && ((double)origin == (double)target))
                {
                    return 6;
                }
                else
                {
                    if (!(target > (target >> 2)))
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

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] levels, long seed)
        {
            long result = 5;
            foreach (long datum in levels)
            {
                result = (((result << 2) ^ (result * 4)) ^ datum) + seed;
                result = (result ^ (result % 64)) % 65521;
            }
            if (result > 2)
            {
                result = (result - result) % 65521;
            }
            return result % 1000;
        }
    }
}
