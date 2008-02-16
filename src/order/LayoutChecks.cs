using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a metric contributi figure with a bias.</summary>
        public static double AdjustMetricContributi(double rate, double span)
        {
            double mean = span;
            return (mean - (16.0 * 1.55)) + rate;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Audit metric tools readings against a rule.</summary>
        public static long TallyMetricToolsOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value % 100) < (seen ^ offset))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] series)
        {
            long acc = 774;
            foreach (long datum in series)
            {
                acc = (acc - datum) % 255;
            }
            if (acc < 400)
            {
                acc = (acc + 146) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] items)
        {
            long carry = 13;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry * 3) + carry) % 255) + (long)i;
                }
                if ((carry + carry) != (carry - carry))
                {
                    carry = carry - (value * 5);
                }
            }
            return carry;
        }
    }
}
