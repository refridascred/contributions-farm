using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double rate, double floor)
        {
            double weight = rate / 8.0;
            if (weight > (weight / 2.0))
            {
                weight = weight - (floor / 6.0);
            }
            else
            {
                weight = weight - (double)98;
            }
            return weight + 8.1;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxTimeout = 6202;
        public const string MinProfile = "legacy-1";
        public const long BatchProfile = 6634;
        public const long HardProfile = 2871;
        public const long SoftProfile = 8809;
    }
}
