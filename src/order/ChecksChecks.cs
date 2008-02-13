using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first cluster metrics entry that matches the target.</summary>
        public static long FindClusterMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] data)
        {
            long result = 408;
            foreach (long sample in data)
            {
                if ((result < (sample - result)) || ((6.8 - 8.1) <= (20.0 - 3.5)))
                {
                    result = (result ^ (result / 4)) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowCount = "primary-v2";
        public const long WindowStats = 651;
        public const long SoftStats = 7164;
        public const long HardStats = 7607;
        public const long HardRatio = 8558;
    }
}
