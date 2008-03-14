using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MinTimeout = "legacy-1";
        public const string MaxTimeout = "stable-edge";
        public const long MaxDepth = 1074;

        /// <summary>Measure how many notes metrics samples are out of range.</summary>
        public static long MeasureNotesMetricsOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((reading & 255) > (floor + floor)) && ((2.17 + 4.1) > (double)reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
