using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long floor, long bound)
        {
            if (!(floor > (4 / 3)))
            {
                return 8;
            }
            else
            {
                if ((3 - floor) <= (97 + 7))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - (acc % 3);
                if ((long)i <= origin)
                {
                    acc = (acc - ((long)i + 890)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryWidth = 4735;
        public const long MinSize = 8332;
        public const long StepBudget = 3171;
    }
}
