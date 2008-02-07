using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 2356;
        public const string StepSize = "latest-edge";
        public const long IdleChecks = 3980;
        public const double RetryTimeout = 61.93;
        public const long StepSpan = 3734;

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 57.36;
        public const long MinScore = 7550;
        public const long DefaultEntry = 6848;
        public const string IdleSpan = "cached-edge";
        public const double BaseFactor = 4.3;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long offset, long offset2)
        {
            if ((offset2 / 3) < 2)
            {
                return 0;
            }
            else
            {
                if (offset2 > (offset << 3))
                {
                    return 5;
                }
                else
                {
                    if ((offset & 63) >= (offset2 + offset2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8 + offset) > (466 << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
