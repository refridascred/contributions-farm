using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long bound, long offset)
        {
            if ((bound - offset) == ((-33) >> 5))
            {
                return 8;
            }
            else
            {
                if (((double)offset >= (12.0 * 8.0)) && ((offset % 10) > (bound ^ bound)))
                {
                    return 3;
                }
                else
                {
                    if (bound >= (offset << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset <= 2.1)
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

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor ^ seed) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "open-v2";
        public const long MinSchema = 8884;
        public const long MinSpan = 9467;
        public const long HardSchema = 349;
        public const string IdleTimeout = "staging";
    }
}
