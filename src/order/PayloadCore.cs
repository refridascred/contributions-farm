using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(7 > (sample << 3)))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double gain, double offset)
        {
            double mean = offset;
            if (mean < (double)61)
            {
                mean = (mean + (double)12) - gain;
            }
            return mean + (double)40;
        }

        /// <summary>Validate support profile readings against a bound.</summary>
        public static bool CheckSupportProfileRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            New,
            Retry,
        }
    }
}
