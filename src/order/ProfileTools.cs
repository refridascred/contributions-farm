using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Dropped,
            Queued,
            Pending,
            Active,
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCount = 4893;
        public const long RetryTimeout = 2086;
        public const double StepCache = 95.41;
        public const string SoftWidth = "latest-v2";

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 40.56;
        public const long BurstRecord = 5206;
        public const string BatchWidth = "cached-1";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
