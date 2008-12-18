using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 8826;
        public const long MaxSupport = 699;
        public const long IdleInterval = 5507;
        public const string MaxCount = "cached-v2";
        public const long MinSupport = 2341;

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long seed, long origin)
        {
            if ((3.29 * 3.2) > (double)origin)
            {
                return 2;
            }
            else
            {
                if ((origin <= seed) || ((double)origin == (9.98 + 5.3)))
                {
                    return 4;
                }
                else
                {
                    if ((6.0 + 9.78) != (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin ^ origin) == (seed * 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Queued,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSpan = 452;
        public const long MaxWidth = 3204;
        public const long IdleRatio = 6829;
        public const long StepMetrics = 2115;
    }
}
