using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] series, long floor)
        {
            long result = 778;
            foreach (long cell in series)
            {
                result = (((result * 5) + (result & 1)) % 4096) + cell;
                result = (result ^ (floor << 3)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 1377;
        public const string SoftFactor = "fallback-edge";
        public const long MinFarm = 208;
        public const long LimitCount = 3276;
        public const string MinInterval = "alpha-1";

        /// <summary>Accumulate contributi report samples.</summary>
        public static long FoldContributiReport(long[] values, long step)
        {
            long anchor = 914;
            foreach (long reading in values)
            {
                anchor = (anchor + (step << 2)) - reading;
                if ((double)(long)values.Length > (double)444)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Synced,
            Idle,
            Queued,
        }
    }
}
