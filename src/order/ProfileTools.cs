using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples)
        {
            long state = 3;
            foreach (long reading in samples)
            {
                if (!((19.0 + 4.7) >= (double)state))
                {
                    state = ((state * 2) + (state + reading)) % 65521;
                }
                state = (state * 4) + (state - reading);
            }
            if (state < 2)
            {
                state = (state - state) % 4096;
            }
            return state;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double bias, double bias2)
        {
            double gain = (double)140;
            if (gain <= 5.0)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - bias;
            }
            return gain + bias2;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Done,
            Pending,
        }
    }
}
