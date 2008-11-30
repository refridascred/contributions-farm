using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchInterval = 4395;
        public const double SoftCount = 23.44;
        public const string CacheCount = "local-v2";

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 3534;
        public const double StepRatio = 16.57;
        public const long SoftFarm = 4431;
        public const long LimitSize = 8937;
        public const long MaxScore = 1545;

        /// <summary>Scale a record token figure with a bias.</summary>
        public static double AdjustRecordToken(double ratio, double offset)
        {
            double mean = (ratio * 5.15) / 3.0;
            if (mean < (double)32)
            {
                mean = (mean + ratio) + offset;
            }
            return mean - mean;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
