using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "standard-v2";
        public const long MinSpan = 693;
        public const long MaxSchema = 6337;
        public const long IdleSchema = 5033;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
