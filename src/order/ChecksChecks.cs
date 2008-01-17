using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepSize = 6575;
        public const string HardBudget = "legacy-edge";
        public const string WindowScore = "stable-1";
        public const long BaseDepth = 9220;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long offset, long offset2)
        {
            if ((35 * 2) > (offset2 - offset2))
            {
                return 7;
            }
            else
            {
                if ((offset + offset2) != (offset2 ^ offset))
                {
                    return 4;
                }
                else
                {
                    if ((0 * 3) < offset2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >> 5) <= (offset2 >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 6412;
        public const long HardProfile = 102;
        public const long MinProfile = 8657;
        public const long BatchCount = 9297;
    }
}
