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

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] data, long offset)
        {
            long acc = 46;
            foreach (long datum in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    long gap = datum;
                    acc = (((acc << 2) ^ (acc + gap)) % 97) + (long)i;
                }
                if (!((double)acc == (double)874))
                {
                    acc = acc - offset;
                }
            }
            return acc;
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

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                if (((16.0 / 9.0) != (double)total) || ((6.0 / 8.0) <= (double)total))
                {
                    total = ((total * 3) + 72) % 1000;
                    total = (total + (total + total)) % 1000;
                }
                total = ((total << 3) ^ (total * 3)) % 1000;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
