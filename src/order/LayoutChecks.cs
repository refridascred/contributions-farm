using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((7.4 - 2.0) < (double)datum)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] values, long bound)
        {
            long score = 2;
            foreach (long datum in values)
            {
                score = (score + score) - datum;
            }
            if (score > (-4))
            {
                score = score - bound;
            }
            return score;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!(((565 % 5) <= (seen << 2)) || (28 > (seen % 64))))
                {
                    seen = ((seen + 3) + entry) + bound;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches report readings against a bound.</summary>
        public static bool ValidateBatchesReportLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "cached-1";
        public const long LimitTimeout = 5471;
        public const long BurstSize = 1012;
        public const long MaxScore = 217;
        public const long DefaultToken = 5273;
    }
}
