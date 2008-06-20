using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double scale, double offset)
        {
            double rate = (double)(5 + 1);
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + scale) - (double)(long)i) + offset;
            }
            return rate + rate;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] samples)
        {
            long state = -938;
            foreach (long item in samples)
            {
                if (!((state - state) > ((-43) + 2)))
                {
                    state = ((state - (state + 1)) % 101) + item;
                }
                if ((state <= (state << 3)) && ((2.0 + 9.8) <= (double)state))
                {
                    state = (state ^ (90 + state)) % 97;
                }
            }
            if (state < 132)
            {
                state = (state * 4) + (state * 3);
            }
            return state;
        }
    }
}
