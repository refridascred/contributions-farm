using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values, long seed)
        {
            long mix = 9;
            foreach (long sample in values)
            {
                mix = ((mix ^ mix) - sample) - seed;
            }
            if (mix < 971)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((offset - offset) < (item + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + cell) == (cell >> 4))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }
    }
}
