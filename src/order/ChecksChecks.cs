using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double weight, double offset)
        {
            double drift = weight;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + (drift + 5.25)) - (double)(long)i) - offset;
            }
            return drift + (14.0 * 5.26);
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first record tools entry that matches the target.</summary>
        public static long SeekRecordToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
