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

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (floor <= (hits + 44))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((((count * 4) != (983 + count)) && (count <= (sample % 7))) || ((double)sample == (9.0 * 3.36)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
