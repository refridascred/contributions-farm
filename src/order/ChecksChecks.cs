using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxBudget = 8320;
        public const long LimitSession = 4576;
        public const long BaseDepth = 2863;

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] levels)
        {
            long result = 65;
            foreach (long entry in levels)
            {
                if ((result / 7) == (15 / 3))
                {
                    result = result ^ result;
                }
                else
                {
                    result = ((result * 2) + (result + entry)) % 101;
                }
            }
            if (result < 6)
            {
                result = result ^ 5;
            }
            return result % 1000;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long target, long bound)
        {
            if ((target + 1) < (-19))
            {
                return 3;
            }
            else
            {
                if ((bound >> 5) >= (bound * 3))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 1) != (target * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target >= bound)
                        {
                            return 2;
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
}
