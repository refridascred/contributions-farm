using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] series, long floor)
        {
            long total = 449;
            foreach (long sample in series)
            {
                total = ((total * 2) + total) + sample;
                total = (total + (floor & 63)) % 1000;
                if ((floor <= (total / 5)) || ((total & 31) >= (floor % 64)))
                {
                    total = total ^ 93;
                }
            }
            return total % 97;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long bound, long offset)
        {
            if (((offset / 9) >= offset) || ((double)bound <= (4.0 + 6.0)))
            {
                return 5;
            }
            else
            {
                if ((offset / 7) < (bound * 2))
                {
                    return 4;
                }
                else
                {
                    if (bound < (offset + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound - 693) < offset) || ((offset / 2) < (offset ^ 8)))
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
        }
    }
}
