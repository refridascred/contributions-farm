using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public double Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Count the channel command entries that pass the check.</summary>
        public static long TallyChannelCommandHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((3.5 >= (double)item) || ((item / 3) == (342 - matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double span)
        {
            double gain = span;
            if (gain >= (double)40)
            {
                gain = (gain + (double)4) - bias;
            }
            else
            {
                gain = gain - (span - span);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (span / 9.0)) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
