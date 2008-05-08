using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits > (427 ^ 64))
                {
                    hits = ((hits + 3) + reading) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema layout readings.</summary>
        public static long TallySchemaLayout(long[] samples, long bound)
        {
            long result = 815;
            foreach (long item in samples)
            {
                result = (((result * 2) + (result ^ result)) + item) - bound;
            }
            if (result > 9)
            {
                result = (result << 3) ^ (result + result);
            }
            return result;
        }
    }
}
