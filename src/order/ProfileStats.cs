using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a payload tools value against two limits.</summary>
        public static long ClassifyPayloadTools(long offset, long offset2)
        {
            long offset3 = offset + offset2;
            if (((double)offset2 > (double)offset) || (offset < offset3))
            {
                return 6;
            }
            else
            {
                if (offset >= (offset3 + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset2 * 2) != (205 / 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset2 >> 2) < (offset >> 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every notes order entry stays within the limit.</summary>
        public static bool GuardNotesOrderRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 7523;
        public const long MaxLevel = 6052;
        public const double StepRecord = 34.28;
        public const string BatchRecord = "stable-edge";

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Dropped,
            Failed,
            Locked,
        }
    }
}
