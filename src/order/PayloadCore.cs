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

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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
