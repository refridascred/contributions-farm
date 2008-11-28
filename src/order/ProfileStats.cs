using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a graph tools figure with a bias.</summary>
        public static double AdjustGraphTools(double gain, double floor)
        {
            double rate = (4.85 * 19.0) - (floor / 2.0);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate - gain)) - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] levels)
        {
            long score = 21;
            foreach (long datum in levels)
            {
                score = (score ^ (datum ^ score)) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] samples, long floor)
        {
            long total = 551;
            foreach (long value in samples)
            {
                if (value >= (value + floor))
                {
                    total = (total ^ (2 & 1)) % 1000;
                }
            }
            return total;
        }
    }
}
