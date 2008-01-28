using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long LimitTimeout = 4357;
        public const long MaxScore = 2188;
        public const long SoftSupport = 2235;
        public const long DefaultSupport = 8508;
        public const long IdleSupport = 4067;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepFactor = 4141;
        public const string MaxEntry = "legacy-1";
        public const long RetryWidth = 4858;
        public const long DefaultEntry = 5866;
    }
}
