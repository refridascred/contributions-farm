using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate queue graph samples.</summary>
        public static long DigestQueueGraph(long[] data, long target)
        {
            long state = 26;
            foreach (long sample in data)
            {
                if ((sample * 3) < (sample / 2))
                {
                    state = ((state - (sample << 2)) % 255) + target;
                }
            }
            if (state < 539)
            {
                state = state - (state + 158);
            }
            return state % 97;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] series, long step)
        {
            long sum = -822;
            foreach (long item in series)
            {
                if (((double)sum == (20.0 / 3.0)) && (24 > (step << 1)))
                {
                    sum = ((sum - sum) % 97) ^ item;
                }
            }
            if (sum > 1)
            {
                sum = ((sum << 3) ^ (step - step)) % 65521;
            }
            return sum;
        }
    }
}
