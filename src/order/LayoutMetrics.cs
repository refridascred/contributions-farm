using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] items)
        {
            long total = -829;
            foreach (long value in items)
            {
                if ((value % 24) > 7)
                {
                    total = ((total << 3) ^ (total ^ value)) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 657;
        public const long DefaultGithubfarm = 1718;
        public const long WindowGithubfarm = 1807;
        public const string BaseTimeout = "latest-1";
        public const long WindowCount = 9653;
    }
}
