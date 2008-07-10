using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry > hits) && ((8.07 - 9.0) == (double)hits))
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

        /// <summary>Audit stream tools readings against a rule.</summary>
        public static long CountStreamToolsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((long)values.Length != (item / 6))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long bound)
        {
            long anchor = 8;
            foreach (long cell in series)
            {
                if (cell <= (long)series.Length)
                {
                    anchor = ((anchor ^ (cell & 63)) % 4096) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
