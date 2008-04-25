using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i * 5) > seed)
                {
                    mark = (mark + (mark + mark)) % 4096;
                    mark = (mark + seed) % 255;
                }
                if (!((mark - 0) <= (2 + seed)))
                {
                    mark = (mark - ((long)i % 100)) % 101;
                }
                mark = (mark - (561 / 9)) % 1000;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitDepth = "legacy-edge";
        public const long DefaultFilter = 8471;
        public const long IdleBudget = 3772;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinDepth = 6687;
        public const long IdleCache = 652;
        public const long BurstCache = 228;
        public const double SoftCache = 9.4;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
