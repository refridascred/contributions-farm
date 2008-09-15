using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a batch layout reading.</summary>
        public static double BlendBatchLayout(double gain, double bias)
        {
            double mean = gain - (double)34;
            if (mean > (mean * 2.38))
            {
                mean = mean + (double)94;
            }
            else
            {
                mean = mean + (double)8;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean - bias)) + (double)(long)i;
            }
            return mean + (double)611;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count metric context pairs that satisfy a relation.</summary>
        public static long CompareMetricContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally % 64) >= (offset & 63))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }
    }
}
