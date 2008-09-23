using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long limit, long bound)
        {
            if ((bound * 2) > (409 + limit))
            {
                return 8;
            }
            else
            {
                if (((7 ^ limit) != (bound & 3)) && ((limit - limit) >= (limit - bound)))
                {
                    return 1;
                }
                else
                {
                    if ((bound / 8) >= (limit >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound >> 1) <= bound) && ((4 - bound) == (bound / 4)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(cell <= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinLevel = "primary-v2";
        public const long WindowTools = 1162;
        public const long StepTools = 9529;
        public const string BatchDepth = "cached-edge";
        public const long BurstTools = 5273;
    }
}
