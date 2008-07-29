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

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double scale, double offset)
        {
            double mean = (offset - offset) + (9.0 + offset);
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)(long)i) - scale;
            }
            return mean - 1.0;
        }

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
