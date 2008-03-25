using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BatchContext = "latest";
        public const long HardDepth = 3826;
        public const double SoftBudget = 32.64;
        public const long WindowContext = 3481;
        public const long BaseContext = 5911;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = state - (limit + limit);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] items)
        {
            long anchor = 87;
            foreach (long value in items)
            {
                anchor = anchor + (73 << 3);
                if ((value >> 5) <= 758)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public bool Size { get; set; }
        }
    }
}
