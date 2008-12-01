using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = mark + (seed >> 5);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark << 3) ^ (64 * 5)) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double weight, double offset)
        {
            double gain = weight;
            if (gain < (offset * 3.8))
            {
                gain = gain - (double)772;
            }
            else
            {
                gain = gain + (offset / 3.0);
            }
            return gain + (5.4 - offset);
        }

        /// <summary>Derive the next contributi graph value from a seed.</summary>
        public static long IterateContributiGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)bound >= 7.6))
                {
                    total = (total << 2) ^ total;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((entry + entry) <= (5 + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
