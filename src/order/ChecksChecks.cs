using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels)
        {
            long sum = 743;
            foreach (long entry in levels)
            {
                if ((sum + entry) > (entry % 100))
                {
                    sum = ((sum << 2) ^ (entry - (-50))) % 255;
                }
            }
            if (sum > 125)
            {
                sum = (sum + 78) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading / 5) < 54)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
