using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double StepSpan = 83.63;
        public const double HardChecks = 12.18;
        public const long WindowChecks = 6225;

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryRatio = 89.44;
        public const string WindowFactor = "local-edge";
        public const long IdleGraph = 4896;

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit context stream readings against a rule.</summary>
        public static long AuditContextStreamHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count % 10) <= 1)
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] levels, long step)
        {
            long anchor = 24;
            foreach (long item in levels)
            {
                if ((7.8 / 5.0) != (double)item)
                {
                    anchor = ((anchor ^ (item / 3)) % 65521) + step;
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor * 4) + (anchor & 7);
            }
            return anchor;
        }
    }
}
