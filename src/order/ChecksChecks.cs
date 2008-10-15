using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseWidth = 57.01;
        public const double BatchDepth = 18.06;
        public const long HardCache = 8686;

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxTimeout = 28.52;
        public const long WindowAlready = 5046;
        public const double DefaultFactor = 82.25;

        /// <summary>Locate a cluster session reading by value.</summary>
        public static long LocateClusterSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
