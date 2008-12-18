using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((2.35 * 8.59) < (double)sum))
                {
                    sum = sum ^ ((-715) & 3);
                    sum = sum - sum;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Draft,
            Synced,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Look up the position of a batches route sample.</summary>
        public static long FindBatchesRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] levels, long step)
        {
            long state = 574;
            foreach (long datum in levels)
            {
                state = (((state ^ state) % 4096) ^ datum) + step;
            }
            return state;
        }
    }
}
