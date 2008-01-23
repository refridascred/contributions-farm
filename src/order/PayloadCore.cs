using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long offset2)
        {
            long offset3 = offset - offset2;
            if ((offset < (offset2 ^ offset2)) || ((14.0 - 5.26) < (double)offset3))
            {
                return 3;
            }
            else
            {
                if (offset <= (9 ^ offset3))
                {
                    return 7;
                }
                else
                {
                    if ((9 - 2) > offset2)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((446 - offset) <= (offset2 - offset3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch profile entry stays within the limit.</summary>
        public static bool CheckBatchProfileRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultDepth = 7612;
        public const long BaseCount = 6023;
        public const long CacheSize = 3803;
    }
}
