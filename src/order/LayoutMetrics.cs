using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next graph report value.</summary>
        public static double ProjectGraphReport(double bias, double bias2)
        {
            double weight = bias2;
            if (weight <= (bias / 2.0))
            {
                weight = weight - bias2;
            }
            return weight - (bias2 * 1.91);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample <= seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
