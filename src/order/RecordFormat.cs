using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count checks already pairs that satisfy a relation.</summary>
        public static long MatchChecksAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Active,
            Draft,
        }

        /// <summary>Grade a payload editor value against two limits.</summary>
        public static long BucketPayloadEditor(long offset, long offset2)
        {
            long offset3 = offset - offset2;
            if (!((9 + offset3) <= offset2))
            {
                return 3;
            }
            else
            {
                if ((offset3 + 488) == (43 + offset))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset2 < (8.1 * 17.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset2 != (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Done,
            Closed,
            Pending,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 2435;
        public const long WindowBudget = 144;
        public const long CacheBudget = 5606;
        public const long HardCount = 6620;
        public const double MaxRatio = 79.29;
    }
}
