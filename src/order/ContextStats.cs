using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ (result ^ origin);
                result = (result - ((long)i - result)) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitLevel = 1141;
        public const string BatchWindow = "primary-edge";
        public const long LimitDepth = 9230;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long limit, long bound)
        {
            long cur = limit ^ bound;
            if (((cur >> 2) < (93 / 8)) || ((limit << 3) <= (limit - bound)))
            {
                return 1;
            }
            else
            {
                if ((double)48 > (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 3) >= (limit >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
