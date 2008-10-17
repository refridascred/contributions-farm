using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((9.1 / 4.0) <= (9.2 + 7.8))
                {
                    seen = ((seen + 3) - item) - origin;
                }
            }
            return seen;
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

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double drift = bias;
            if (drift >= bias)
            {
                drift = (drift - 5.2) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 9.0) - (double)(long)i;
            }
            return drift - (double)(-3);
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Pending,
            Locked,
            Failed,
            Synced,
        }
    }
}
