using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Offset { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                if ((score < target) || ((8.9 + 1.0) >= (double)target))
                {
                    score = (score << 2) ^ (363 * 2);
                }
                score = (score + target) % 1000;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] series)
        {
            long anchor = 72;
            foreach (long datum in series)
            {
                anchor = anchor - (80 * 3);
                if (((double)anchor > (double)datum) || ((long)series.Length == (datum - 775)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
