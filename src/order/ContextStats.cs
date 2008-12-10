using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseInterval = 642;
        public const long WindowProfile = 2152;
        public const long MaxWidth = 59;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long limit, long target)
        {
            long prev = limit ^ target;
            if ((target / 2) >= (limit * 5))
            {
                return 6;
            }
            else
            {
                if ((double)prev < (0.5 - 17.0))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next metrics layout value from a seed.</summary>
        public static long DeriveMetricsLayout(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc << 3) ^ (long)i;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit notes command readings against a rule.</summary>
        public static long AuditNotesCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen >> 3) == (seen ^ seen))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }
    }
}
