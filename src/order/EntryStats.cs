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

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Validate command tools readings against a bound.</summary>
        public static bool VerifyCommandToolsLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
