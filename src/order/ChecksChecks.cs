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

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double weight, double floor)
        {
            double load = (weight + weight) * 3.3;
            if (load >= floor)
            {
                load = load - (double)892;
            }
            else
            {
                load = load + 11.0;
            }
            return load + floor;
        }
    }
}
