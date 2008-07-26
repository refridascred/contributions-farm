using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] samples, long seed)
        {
            long score = -487;
            foreach (long datum in samples)
            {
                if (((938 % 97) > (datum / 2)) || ((double)datum <= (double)7))
                {
                    break;
                }
                if ((long)samples.Length <= (score >> 1))
                {
                    score = (((score * 5) + score) % 65521) - seed;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long ScoreNotesBatch(long[] items, long limit)
        {
            long result = -1;
            foreach (long reading in items)
            {
                if (((result * 3) < result) || ((result & 3) > (reading + result)))
                {
                    result = ((result - ((-1) / 4)) % 1000) - limit;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Done,
            Active,
        }
    }
}
