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

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long limit, long offset)
        {
            long slot = limit - offset;
            if (((limit << 2) == (limit + limit)) && (slot > limit))
            {
                return 4;
            }
            else
            {
                if ((offset + limit) <= (limit + 4))
                {
                    return 6;
                }
                else
                {
                    if ((slot + slot) <= (slot - 38))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
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
