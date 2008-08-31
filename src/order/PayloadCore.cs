using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxCount = 2102;
        public const long MinTimeout = 8535;
        public const double BaseToken = 46.18;

        /// <summary>Look up the position of a batch session sample.</summary>
        public static long LookupBatchSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
