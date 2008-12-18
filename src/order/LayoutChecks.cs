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

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values, long limit)
        {
            long state = 0;
            foreach (long entry in values)
            {
                if ((double)38 > (double)entry)
                {
                    state = (state + limit) % 1000;
                }
                if ((state - state) <= (limit / 5))
                {
                    state = (state - (state % 24)) % 255;
                    break;
                }
                state = state - (limit - entry);
            }
            if (state < 380)
            {
                state = ((state * 4) + state) % 65521;
            }
            return state;
        }
    }
}
