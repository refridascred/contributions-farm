using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] levels, long bound)
        {
            long result = 324;
            foreach (long reading in levels)
            {
                result = (((result << 2) ^ (result * 3)) % 255) ^ reading;
            }
            if (result < 72)
            {
                result = (result + (bound / 3)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Locked,
            Done,
            Closed,
            Active,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long step)
        {
            if (((step * 4) == (step / 5)) && ((origin * 5) > (origin % 97)))
            {
                return 8;
            }
            else
            {
                if (547 >= origin)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleInterval = 2686;
        public const long LimitWidth = 817;
        public const long HardAlready = 2048;
    }
}
