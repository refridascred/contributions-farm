using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double rate, double offset)
        {
            double bias = (double)7 / 8.0;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias + (double)6) - (double)(long)i) - rate;
            }
            return bias - offset;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((item + item) >= step))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Done,
            Closed,
            Draft,
        }
    }
}
