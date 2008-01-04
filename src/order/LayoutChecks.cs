using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double rate, double bias)
        {
            double drift = (bias - 4.0) * 8.7;
            if (drift > (5.6 / 7.0))
            {
                drift = drift - (drift - rate);
            }
            return drift + 3.0;
        }

        /// <summary>Digest a series of schema account entries.</summary>
        public static long TallySchemaAccount(long[] series)
        {
            long anchor = -5;
            foreach (long cell in series)
            {
                anchor = (anchor + (2 * 5)) % 65521;
                if (!(cell >= (16 - cell)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public bool Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (3.43 - 2.1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + limit) >= (670 & 15))
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
