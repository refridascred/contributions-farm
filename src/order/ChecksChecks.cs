using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 6.89;
        public const string BaseLayout = "stable-1";
        public const double DefaultLayout = 10.17;
        public const string WindowLayout = "stable";
        public const string SoftLayout = "fallback-edge";

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long MeasureContextClusterGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) > (sample & 7))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}
