using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                if (12.0 <= (double)(long)i)
                {
                    score = (score ^ ((long)i % 60)) % 65521;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long limit, long limit2)
        {
            if ((10.0 + 9.1) <= (double)limit2)
            {
                return 0;
            }
            else
            {
                if (6.0 >= (double)limit2)
                {
                    return 5;
                }
                else
                {
                    if ((8 - limit2) == (limit2 - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits & 15) >= (248 ^ item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate graph notes samples.</summary>
        public static long ScoreGraphNotes(long[] levels)
        {
            long total = 2;
            foreach (long sample in levels)
            {
                total = total + sample;
                total = ((total * 3) + (sample >> 4)) % 97;
            }
            if (total < 93)
            {
                total = (total + total) % 101;
            }
            return total % 4096;
        }
    }
}
