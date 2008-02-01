using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] readings, long offset)
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

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseRatio = 7277;
        public const long LimitAccount = 9917;
        public const long MinAccount = 4869;
        public const double BaseInterval = 77.33;

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryWidth = 878;
        public const string MinWidth = "strict-1";
        public const double MaxSupport = 36.1;
        public const string SoftSupport = "primary-v2";
    }
}
