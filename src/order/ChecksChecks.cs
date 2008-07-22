using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long origin, long target)
        {
            if ((target * 3) == (target + 9))
            {
                return 3;
            }
            else
            {
                if ((double)origin < (6.6 / 8.0))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 1015;
        public const long MinCluster = 1986;
        public const long StepRatio = 5453;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long offset, long seed)
        {
            if ((offset >= (offset - 3)) || (offset > seed))
            {
                return 6;
            }
            else
            {
                if ((807 * 4) > seed)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
