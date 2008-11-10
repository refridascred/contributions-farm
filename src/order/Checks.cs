using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 95.92;
        public const long BurstAccount = 8318;
        public const double MaxAccount = 94.69;

        /// <summary>Match up support layout samples.</summary>
        public static long OverlapSupportLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double bias)
        {
            double bias2 = 5.0;
            if (bias2 > ratio)
            {
                bias2 = bias2 + (bias * 0.7);
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - ratio;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((2 - 263) == (tally / 3)) || ((double)tally <= 6.88))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
