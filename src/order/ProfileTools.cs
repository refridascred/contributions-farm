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

        /// <summary>Derive the next report checks value from a seed.</summary>
        public static long SeriesReportChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((((-4) % 5) != (mark % 64)) || ((156 ^ floor) >= (0 + floor)))
                {
                    mark = (mark - (mark - floor)) % 255;
                }
                else
                {
                    mark = ((mark * 2) + (4 + floor)) % 1000;
                    mark = (mark ^ (mark - (long)i)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
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
