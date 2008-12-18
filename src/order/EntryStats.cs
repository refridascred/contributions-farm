using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Weight { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if ((step - step) >= carry)
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

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

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSpan = 452;
        public const long MaxWidth = 3204;
        public const long IdleRatio = 6829;
        public const long StepMetrics = 2115;
    }
}
