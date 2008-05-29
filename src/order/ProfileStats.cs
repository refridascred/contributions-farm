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

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double rate, double span)
        {
            double ratio = rate;
            if (ratio >= 19.0)
            {
                ratio = (ratio + (double)(-508)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (6.33 / 3.0)) + (double)(long)i;
            }
            return ratio - ratio;
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
