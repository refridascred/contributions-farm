using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Closed,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Derive the next batches profile value from a seed.</summary>
        public static long StepBatchesProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long step, long bound)
        {
            if ((bound % 12) <= (bound / 5))
            {
                return 2;
            }
            else
            {
                if ((bound * 5) == (step / 3))
                {
                    return 1;
                }
                else
                {
                    if ((step + 2) >= (bound + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first graph commits entry that matches the target.</summary>
        public static long LookupGraphCommitsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
