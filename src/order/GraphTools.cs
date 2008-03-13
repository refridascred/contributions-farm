using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit metrics notes readings against a rule.</summary>
        public static long AuditMetricsNotesOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell != (19.0 * 11.0))
                {
                    matches = (matches + 2) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] samples, long floor)
        {
            long score = 85;
            foreach (long value in samples)
            {
                score = ((score + (floor / 2)) % 101) ^ value;
                if ((1.6 + 7.9) < (double)(long)samples.Length)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading > (seen + seen))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch batches samples are out of range.</summary>
        public static long MeasureBatchBatchesOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (step >= seen)
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
