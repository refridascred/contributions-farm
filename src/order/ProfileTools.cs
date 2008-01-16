using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "fallback-1";
        public const long MinSupport = 1042;
        public const double IdleWidth = 30.73;

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] levels, long offset)
        {
            long anchor = 283;
            foreach (long datum in levels)
            {
                if (((0 + datum) < datum) && ((7 * 2) != (datum % 24)))
                {
                    anchor = ((anchor * 5) + ((-93) << 1)) - offset;
                }
            }
            return anchor;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long offset)
        {
            if (target <= (target - target))
            {
                return 0;
            }
            else
            {
                if ((double)offset < (9.0 + 1.78))
                {
                    return 3;
                }
                else
                {
                    if (((1.4 / 9.0) != (double)target) && ((double)offset <= (3.0 - 2.21)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((3.01 * 2.0) != (double)offset) || ((25 ^ target) < (-847)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state + floor) % 4096) ^ (long)i2;
                    state = (state ^ (long)i) % 65521;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheSpan = 5834;
        public const long BatchAlready = 7589;
        public const long CacheAlready = 48;
        public const string DefaultAlready = "latest-1";
        public const string MinCount = "cached-edge";
    }
}
