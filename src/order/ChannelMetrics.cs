using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchFactor = "legacy-edge";
        public const long BaseCommand = 4451;
        public const long WindowBudget = 9821;

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long step, long seed)
        {
            if ((seed + 95) != (seed * 3))
            {
                return 6;
            }
            else
            {
                if (((19.0 + 3.0) >= (double)step) || ((double)seed < (9.0 - 7.1)))
                {
                    return 7;
                }
                else
                {
                    if ((seed < (step - step)) || ((seed << 1) > (74 * 5)))
                    {
                        return 3;
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
