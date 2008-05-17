using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] samples)
        {
            long mark = 28;
            foreach (long reading in samples)
            {
                if ((double)reading < (6.06 * 20.0))
                {
                    mark = (mark << 3) ^ (reading ^ 880);
                }
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 9481;
        public const long MaxTimeout = 6132;
        public const long StepSize = 3934;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((datum % 8) == (tally + tally)))
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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
