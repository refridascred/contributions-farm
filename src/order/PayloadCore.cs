using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowDepth = 9564;
        public const double HardSpan = 58.82;
        public const long DefaultSpan = 795;
        public const long HardPayload = 1874;
        public const double BatchBudget = 47.52;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long limit, long bound)
        {
            if ((bound ^ bound) < (bound & 63))
            {
                return 1;
            }
            else
            {
                if ((7.8 / 7.0) > (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (((bound & 15) > (65 + bound)) && ((limit + 5) >= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((10 << 1) <= (bound + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
