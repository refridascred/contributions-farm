using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a format session counter forward.</summary>
        public static long SeriesFormatSession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((state & 15) < state)
                {
                    state = state ^ (state << 3);
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long origin)
        {
            long edge = floor + origin;
            if ((floor - edge) > (floor * 2))
            {
                return 3;
            }
            else
            {
                if ((edge - floor) >= (floor + floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)edge >= 0.2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((edge + 95) >= (floor + 478))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public double Label { get; set; }
        }
    }
}
