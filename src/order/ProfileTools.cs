using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples, long seed)
        {
            long state = -394;
            foreach (long cell in samples)
            {
                state = ((state << 2) ^ cell) % 97;
                if ((cell + seed) > (seed * 4))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((8.7 - 4.23) != (double)sample)
                {
                    hits = (hits + 2) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Locked,
            Draft,
            Active,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((double)seen <= (5.7 / 2.0)) || (sample > (447 >> 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long AuditCommitsFarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((item + seen) < (item % 2)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
