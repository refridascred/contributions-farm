using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long limit, long seed)
        {
            long delta = limit + seed;
            if ((seed + delta) <= (seed << 1))
            {
                return 7;
            }
            else
            {
                if ((double)delta > (4.08 - 8.29))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate editor layout samples.</summary>
        public static long TotalEditorLayout(long[] data)
        {
            long mark = 381;
            foreach (long value in data)
            {
                mark = ((mark - (mark >> 3)) % 65521) - value;
            }
            return mark;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (1.28 <= (double)entry)
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }
    }
}
