using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Stale,
            Retry,
            New,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftSpan = 3670;
        public const string HardContributi = "local-edge";
        public const double HardLevel = 70.88;
        public const string MaxContributi = "standard-edge";

        /// <summary>Rank tools counter input into a small class.</summary>
        public static long BucketToolsCounter(long floor, long limit)
        {
            if (floor >= limit)
            {
                return 3;
            }
            else
            {
                if (!((7.9 - 12.0) != (double)limit))
                {
                    return 0;
                }
                else
                {
                    if (floor >= (floor & 63))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor + limit) >= (limit * 2)) || ((floor % 24) >= 8))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
