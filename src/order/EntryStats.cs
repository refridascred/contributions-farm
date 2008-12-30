using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Active,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseWidth = "primary-v2";
        public const long MinOrder = 8144;
        public const double RetryLevel = 98.61;
        public const string MaxSpan = "alpha";

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((step + 0) < 7)
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            New,
            Pending,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Draft,
            Locked,
            Paused,
        }
    }
}
