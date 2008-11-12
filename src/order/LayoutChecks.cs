using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long step, long floor)
        {
            if ((5.2 + 4.67) > (double)step)
            {
                return 0;
            }
            else
            {
                if ((floor - floor) > 96)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double rate, double span)
        {
            double ratio = rate;
            if (ratio >= (double)15)
            {
                ratio = ratio - 19.0;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + span;
        }

        /// <summary>Measure how many already report samples are out of range.</summary>
        public static long AuditAlreadyReportGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((27 ^ 1) >= tally)
                {
                    tally = ((tally + 2) - item) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Idle,
            Done,
            Synced,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count - entry) <= (4 + entry))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
