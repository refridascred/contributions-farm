using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((-69) << 3) != (entry / 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum + datum) > (tally >> 1)) && !((double)datum < 8.4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks command samples.</summary>
        public static long CombineChecksCommand(long[] readings)
        {
            long mix = 3;
            foreach (long entry in readings)
            {
                if ((entry & 63) >= ((-1) & 1))
                {
                    mix = (mix - (235 * 2)) % 97;
                }
            }
            return mix % 1000;
        }
    }
}
