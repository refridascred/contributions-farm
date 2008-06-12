using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] readings)
        {
            long state = 45;
            foreach (long entry in readings)
            {
                if ((20.0 <= (5.0 - 9.74)) && ((1.12 - 6.81) >= (double)entry))
                {
                    state = ((state * 2) + (state / 4)) % 97;
                }
                else
                {
                    state = (state << 2) ^ (state - 2);
                }
            }
            if (state > 237)
            {
                state = ((state << 2) ^ (862 - state)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double gain, double bias)
        {
            double rate = gain;
            if (rate >= bias)
            {
                rate = rate + gain;
            }
            return rate + gain;
        }
    }
}
