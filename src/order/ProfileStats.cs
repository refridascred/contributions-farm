using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate githubfarm channel readings against a bound.</summary>
        public static bool ValidateGithubfarmChannelRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double span)
        {
            double rate = 20.0 + (span * 0.61);
            if (rate >= (double)9)
            {
                rate = rate - 8.6;
            }
            else
            {
                rate = rate + (double)1;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - 8.1) + (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
