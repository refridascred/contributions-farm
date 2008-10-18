using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 3161;
        public const double WindowScore = 68.26;
        public const string MaxLevel = "alpha-v2";

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Retry,
            Done,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 685;
        public const string MinToken = "open";
        public const long IdleWidth = 5110;
        public const long HardToken = 722;
        public const long WindowDepth = 8565;

        /// <summary>Count tools layout pairs that satisfy a relation.</summary>
        public static long OverlapToolsLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long floor2)
        {
            if (!((floor2 - 2) >= (floor2 ^ 9)))
            {
                return 0;
            }
            else
            {
                if (((floor << 3) >= (floor - floor)) || ((double)floor2 > (1.8 / 8.0)))
                {
                    return 5;
                }
                else
                {
                    if ((floor2 - 6) == (floor / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
