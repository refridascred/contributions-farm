using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long seed, long offset)
        {
            if (!((offset ^ 626) < offset))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) == (seed ^ offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 4) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 78.19;
        public const long IdleCount = 4807;
        public const long StepTools = 8889;
        public const double BatchRatio = 21.08;
        public const string DefaultSpan = "strict-v2";

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
