using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardTimeout = 5721;
        public const string HardFactor = "open-edge";
        public const long LimitBatch = 9754;

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long offset)
        {
            long lane = limit + offset;
            if ((limit / 2) > ((-6) + lane))
            {
                return 2;
            }
            else
            {
                if (((limit & 63) != (lane / 5)) && (limit > (lane & 31)))
                {
                    return 3;
                }
                else
                {
                    if ((offset + lane) < limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.1 >= (double)offset) || ((double)limit <= 8.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of tools editor entries.</summary>
        public static long DigestToolsEditor(long[] series, long offset)
        {
            long state = 409;
            foreach (long value in series)
            {
                if ((state + 9) > 237)
                {
                    state = state + (offset + value);
                }
                else
                {
                    state = (state + ((-679) * 3)) % 4096;
                }
            }
            return state % 1000;
        }
    }
}
