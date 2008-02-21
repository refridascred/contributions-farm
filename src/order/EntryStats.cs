using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] levels, long offset)
        {
            long acc = 14;
            foreach (long entry in levels)
            {
                acc = (((acc - (long)levels.Length) % 4096) - entry) - offset;
            }
            if (acc < 567)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long seed)
        {
            if (!(step <= (seed ^ 9)))
            {
                return 6;
            }
            else
            {
                if ((723 + seed) < seed)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
