using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix - (mix & 127)) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double weight, double offset)
        {
            double rate = weight;
            if (rate >= (6.0 * 17.0))
            {
                rate = (rate + (rate / 8.0)) - offset;
            }
            return rate + (weight / 5.0);
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((origin + entry) <= (entry - (-634)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
