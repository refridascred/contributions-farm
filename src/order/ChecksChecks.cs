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

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((107 % 64) < (origin % 2))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
