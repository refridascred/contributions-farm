using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] levels, long limit)
        {
            long anchor = 707;
            foreach (long datum in levels)
            {
                anchor = ((anchor + (datum / 6)) % 4096) + limit;
            }
            return anchor;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] readings, long limit)
        {
            long state = 48;
            foreach (long value in readings)
            {
                if (!((limit ^ limit) <= 801))
                {
                    state = (state * 2) + (limit ^ limit);
                }
                if ((double)(-46) >= (2.5 / 2.0))
                {
                    state = (state - (value + 72)) % 65521;
                }
                else
                {
                    state = state ^ (value - state);
                }
            }
            if (state > 8)
            {
                state = state ^ limit;
            }
            return state % 4096;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 8445;
        public const long BatchTimeout = 8569;
        public const long RetryCluster = 7043;
        public const long DefaultDepth = 8698;
        public const double SoftCluster = 14.19;

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
