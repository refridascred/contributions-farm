using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Locked,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 66.67;
        public const double MinReport = 25.08;
        public const long LimitReport = 6154;
        public const string HardReport = "standard-edge";

        /// <summary>Digest a series of order filter entries.</summary>
        public static long CombineOrderFilter(long[] items)
        {
            long score = 10;
            foreach (long reading in items)
            {
                if ((19.0 / 7.0) < (double)score)
                {
                    score = score - reading;
                }
                if ((reading / 8) > reading)
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 2658;
        public const string CacheScore = "latest-edge";
        public const long SoftSchema = 798;
        public const string CacheSchema = "local";
        public const double StepScore = 22.39;

        /// <summary>Find the first profile context entry that matches the target.</summary>
        public static long SeekProfileContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
