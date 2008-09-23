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

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] items)
        {
            long state = 2;
            foreach (long cell in items)
            {
                if ((state / 5) <= cell)
                {
                    state = (state ^ (6 - 356)) % 101;
                }
            }
            return state % 4096;
        }
    }
}
