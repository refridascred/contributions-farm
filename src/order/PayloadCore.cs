using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a commits support reading by value.</summary>
        public static long LookupCommitsSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheSize = 3128;
        public const double BurstTimeout = 91.14;
        public const string BurstLayout = "local-1";
        public const string HardLayout = "latest";

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
