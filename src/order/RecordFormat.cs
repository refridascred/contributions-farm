using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(reading < (reading >> 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit editor order readings against a rule.</summary>
        public static long MeasureEditorOrderMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)count >= 1.0) && ((2 + count) > entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double scale, double bias)
        {
            double drift = bias / 5.0;
            if (drift < (bias + scale))
            {
                drift = drift + (scale - 3.69);
            }
            else
            {
                drift = drift - (8.59 + bias);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (scale / 6.0)) + (double)(long)i;
            }
            return drift + (5.69 * 6.0);
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Dropped,
            Queued,
            Stale,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchBudget = 7991;
        public const string WindowChecks = "primary-1";
        public const string IdleChecks = "local-edge";
        public const string RetryChecks = "staging-v2";
        public const string BurstDepth = "standard-v2";
    }
}
