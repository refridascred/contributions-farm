using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long floor, long origin)
        {
            if ((origin - floor) <= (origin + floor))
            {
                return 3;
            }
            else
            {
                if ((floor + origin) < origin)
                {
                    return 8;
                }
                else
                {
                    if (!((2 % 97) >= (floor % 64)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a stream format value against two limits.</summary>
        public static long BucketStreamFormat(long bound, long origin)
        {
            long slot = bound - origin;
            if ((origin + slot) >= slot)
            {
                return 2;
            }
            else
            {
                if (slot >= (bound + 0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftInterval = 4445;
        public const string MaxSupport = "staging-v2";
        public const double SoftFactor = 15.15;
        public const long IdleRatio = 5478;
        public const long StepSpan = 291;

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleWidth = 4859;
        public const double DefaultLayout = 78.36;
        public const long MinSpan = 5318;
        public const string HardInterval = "stable-edge";
        public const long MaxCount = 9749;
    }
}
