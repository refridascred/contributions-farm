using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first window schema entry that matches the target.</summary>
        public static long LocateWindowSchemaIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile stream readings against a rule.</summary>
        public static long AuditProfileStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits >= (6.9 + 2.48))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double weight2 = (weight + span) + 1.4;
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 - weight;
        }
    }
}
