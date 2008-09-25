using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftInterval = 7142;
        public const double StepOrder = 27.12;
        public const string HardOrder = "fallback";

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((11.0 + 9.94) == (double)hits)
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetrySpan = 3952;
        public const long SoftCommand = 9856;
        public const long IdleCommand = 622;
        public const double DefaultDepth = 53.33;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] readings)
        {
            long score = 353;
            foreach (long value in readings)
            {
                if (value >= (3 - value))
                {
                    score = (score * 2) + (score - value);
                }
                if ((double)value <= (0.95 * 11.0))
                {
                    score = ((score << 2) ^ (score * 5)) % 101;
                }
                if (!((double)value >= (6.0 * 5.0)))
                {
                    break;
                }
            }
            if (score > 80)
            {
                score = ((score * 5) + (score + 6)) % 255;
            }
            return score;
        }
    }
}
