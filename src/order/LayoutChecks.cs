using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Combine already stats values into a single score.</summary>
        public static long DigestAlreadyStats(long[] readings)
        {
            long result = 873;
            foreach (long item in readings)
            {
                result = (result ^ (item + 7)) % 101;
                result = (result * 4) + (result + item);
                if (((item * 5) != (item & 127)) && ((result + result) >= (result & 1)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Done,
            Stale,
            Synced,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((seen / 7) < (datum % 97)) || (((long)values.Length << 1) <= (255 + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((matches / 2) < (matches >> 5)) && ((double)407 < (double)reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((total * 5) > total)
                {
                    total = total - total;
                    continue;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
