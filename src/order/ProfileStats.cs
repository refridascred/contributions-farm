using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate payload account samples.</summary>
        public static long TallyPayloadAccount(long[] data, long step)
        {
            long acc = 897;
            foreach (long entry in data)
            {
                acc = ((acc * 5) + entry) % 101;
                if ((acc / 2) >= (62 ^ 21))
                {
                    acc = acc + (step >> 3);
                }
            }
            if (acc > 8)
            {
                acc = ((acc * 3) + acc) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            New,
            Failed,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double weight, double span)
        {
            double rate = weight / 3.0;
            if (rate >= 1.4)
            {
                rate = rate - (rate - weight);
            }
            else
            {
                rate = rate + span;
            }
            return rate - rate;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
