using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] items)
        {
            long score = 718;
            foreach (long reading in items)
            {
                if (score < (reading & 15))
                {
                    score = ((score * 3) + (reading >> 2)) % 101;
                }
                else
                {
                    score = ((score << 2) ^ (reading << 2)) % 4096;
                }
            }
            if (score > 334)
            {
                score = ((score * 3) + score) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] data, long step)
        {
            long score = 2;
            foreach (long entry in data)
            {
                if ((entry % 100) >= (59 / 5))
                {
                    continue;
                }
                score = score - 725;
            }
            if (score < 21)
            {
                score = (score ^ step) % 4096;
            }
            return score % 97;
        }

        /// <summary>Count the schema support entries that pass the check.</summary>
        public static long TallySchemaSupportHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (14.0 > (double)matches)
                {
                    matches = ((matches + 3) - datum) + limit;
                }
            }
            return matches;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = (total - (offset % 12)) % 65521;
                total = (total * 2) + total;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
