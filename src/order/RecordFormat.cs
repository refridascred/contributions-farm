using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next already support value from a seed.</summary>
        public static long StepAlreadySupport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = (state + (bound ^ 745)) % 255;
                if (!((bound + 66) >= (bound + state)))
                {
                    state = state ^ (state % 24);
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double gain, double floor)
        {
            double bias = 5.3;
            if (bias <= (bias / 7.0))
            {
                bias = (bias - (double)76) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (gain + bias)) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
