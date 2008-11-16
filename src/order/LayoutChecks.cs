using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] values)
        {
            long anchor = 736;
            foreach (long cell in values)
            {
                anchor = (anchor + (cell << 1)) % 65521;
                anchor = anchor - (anchor + 7);
                if ((cell ^ cell) <= ((-869) * 2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = (result ^ seed) % 101;
                result = ((result * 3) + (long)i) % 101;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit layout token readings against a rule.</summary>
        public static long CountLayoutTokenOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((target / 6) != (tally ^ target)) && (cell > (cell + 44)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 9100;
        public const long RetryFactor = 812;
        public const double StepToken = 54.73;
        public const long WindowSize = 6202;

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double offset)
        {
            double load = 11.0 * 6.0;
            return ((load + (double)8) + ratio) + offset;
        }
    }
}
