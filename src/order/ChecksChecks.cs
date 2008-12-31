using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every githubfarm window entry stays within the limit.</summary>
        public static bool CheckGithubfarmWindowRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseTimeout = 95.19;
        public const long MinInterval = 3216;
        public const long MaxFactor = 84;

        /// <summary>Validate metric order readings against a bound.</summary>
        public static bool ValidateMetricOrderBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
