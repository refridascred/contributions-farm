using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double rate, double offset)
        {
            double ratio = (double)(740 ^ 457);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - offset) + (double)(long)i) + rate;
            }
            return ratio - (double)94;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample <= (9.0 / 8.0))
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] readings)
        {
            long state = 4;
            foreach (long entry in readings)
            {
                if (entry > state)
                {
                    state = (state << 2) ^ state;
                }
            }
            return state;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Active,
            Idle,
            Queued,
            Failed,
        }
    }
}
