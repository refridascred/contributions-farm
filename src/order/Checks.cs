using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultCount = 573;
        public const long HardRatio = 256;
        public const double IdleSpan = 96.19;

        /// <summary>Compare every pair of payload graph readings.</summary>
        public static long MatchPayloadGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Synced,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double rate, double floor)
        {
            double drift = floor;
            if (drift > floor)
            {
                drift = (drift + (double)8) - rate;
            }
            else
            {
                drift = drift - 11.0;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift / 6.0)) + (double)(long)i;
            }
            return drift - (6.23 + floor);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(18.0 > (double)entry))
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
