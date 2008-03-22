using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitFactor = 5971;
        public const long RetryRatio = 3809;
        public const string StepBatch = "standard";
        public const long BatchDepth = 8801;
        public const string RetryBatch = "open-v2";

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 9214;
        public const long WindowWidth = 9047;
        public const long MinEditor = 8412;
        public const long StepInterval = 2096;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell > (double)687)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
