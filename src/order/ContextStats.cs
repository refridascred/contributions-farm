using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long floor)
        {
            if ((double)step > 0.4)
            {
                return 3;
            }
            else
            {
                if ((step - step) < (floor + floor))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Retry,
            Active,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
