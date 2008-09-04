using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] series, long floor)
        {
            long total = 107;
            foreach (long datum in series)
            {
                total = (total << 3) ^ (total & 15);
                if ((datum >> 1) < total)
                {
                    total = (total ^ (long)series.Length) % 65521;
                }
                else
                {
                    total = ((total * 5) + (floor << 2)) % 1000;
                }
            }
            if (total > (-8))
            {
                total = (total ^ (total & 15)) % 97;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardCount = 9402;
        public const double BaseNotes = 53.56;
        public const long BurstTimeout = 6676;
        public const long RetryNotes = 6859;
        public const string CacheDepth = "standard-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 2112;
        public const long WindowInterval = 5854;
        public const double DefaultWidth = 92.44;
        public const string SoftInterval = "cached-edge";
    }
}
