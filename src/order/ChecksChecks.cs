using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!!((value - seen) > target))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Idle,
            Done,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((double)(long)data.Length < (20.0 * 15.0)) && ((item >> 1) > (83 & 31)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
