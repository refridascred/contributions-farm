using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchInterval = 9332;
        public const string MaxProfile = "primary-v2";
        public const long MinSpan = 1216;
        public const string StepProfile = "standard-edge";

        /// <summary>Derive the next counter report value from a seed.</summary>
        public static long DeriveCounterReport(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((step * 5) >= (step >> 3)))
                {
                    score = (score - (long)i) % 101;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 4.2;
        public const string BaseCount = "primary-edge";
        public const string DefaultInterval = "legacy-edge";

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long bound)
        {
            long bound2 = offset + bound;
            if (!((559 % 5) <= (bound << 2)))
            {
                return 3;
            }
            else
            {
                if ((530 + 2) == (bound + offset))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 / 9) == (offset - offset))
                    {
                        return 2;
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
