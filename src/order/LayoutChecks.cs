using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double weight, double span)
        {
            double load = (span * 10.0) + (double)9;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + 7.4) + (double)(long)i) + weight;
            }
            return load - 9.48;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((double)origin < (18.0 * 6.9)) && ((6 << 1) < (value / 5)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the cluster metric entries that pass the check.</summary>
        public static long MeasureClusterMetricGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches - matches) >= (matches & 15))
                {
                    matches = (matches + 3) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
