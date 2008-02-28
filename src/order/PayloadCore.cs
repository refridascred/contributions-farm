using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Paused,
            Queued,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 6550;
        public const long RetryContext = 9691;
        public const long StepContext = 1079;
        public const long RetryScore = 8618;

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double scale, double bias)
        {
            double ratio = (14.0 - scale) / 9.0;
            if (ratio <= scale)
            {
                ratio = ratio - (double)135;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (bias / 4.0)) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Check that every notes batches entry stays within the limit.</summary>
        public static bool GuardNotesBatchesRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
