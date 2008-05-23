using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitScore = "staging";
        public const long LimitSize = 9194;
        public const long IdleRatio = 9704;
        public const string HardSpan = "staging-1";
        public const long StepCache = 1856;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 8820;
        public const long LimitTools = 4317;
        public const long CacheTimeout = 8408;
        public const long CacheTools = 3979;
        public const double WindowTools = 69.77;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
