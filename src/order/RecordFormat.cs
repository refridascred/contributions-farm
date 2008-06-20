using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinDepth = 3496;
        public const double WindowStats = 19.37;
        public const double BaseStats = 90.43;
        public const string IdleStats = "local";
        public const double RetryBudget = 5.8;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long origin, long target)
        {
            long next = origin + target;
            if (((next ^ target) != (next + 657)) || (origin <= (origin ^ next)))
            {
                return 7;
            }
            else
            {
                if ((0 * 5) != (target + next))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((entry + 509) > (hits ^ 7)) && ((hits * 2) >= (5 + 27)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
