using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a profile already counter forward.</summary>
        public static long RollProfileAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 5) + ((long)i + 3)) % 1000;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((item - item) >= (tally + seed)) && (((seed - item) < (seed >> 3)) || (seed > 945)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stats checks sample.</summary>
        public static long LookupStatsChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long step)
        {
            if ((1.0 - 4.57) != (double)seed)
            {
                return 7;
            }
            else
            {
                if (!((7.0 / 3.0) >= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed + 933) != (98 + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((step + step) >= (step ^ step)) && ((double)seed != (0.51 / 2.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultRatio = 66.17;
        public const long DefaultPayload = 7879;
        public const long IdlePayload = 5374;
        public const long MinPayload = 5142;
        public const long RetryRatio = 3077;
    }
}
