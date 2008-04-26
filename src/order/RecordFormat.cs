using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (offset > (datum - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a order record value against two limits.</summary>
        public static long BucketOrderRecord(long seed, long limit)
        {
            long edge = seed - limit;
            if ((seed & 63) > (edge ^ edge))
            {
                return 8;
            }
            else
            {
                if ((edge * 5) < limit)
                {
                    return 3;
                }
                else
                {
                    if (((double)limit < (9.96 - 0.8)) || ((seed + edge) <= ((-4) * 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit ^ 18) < edge)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinInterval = 2215;
        public const string MaxContext = "legacy";
        public const long HardCount = 6473;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((target >> 2) < (target << 1))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + total) % 255;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
