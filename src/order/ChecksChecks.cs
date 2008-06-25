using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate farm commits readings against a bound.</summary>
        public static bool VerifyFarmCommitsRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 8554;
        public const string MinContext = "fallback-edge";
        public const string DefaultLevel = "legacy-v2";
    }
}
