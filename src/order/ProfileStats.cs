using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((2.95 * 2.2) == (double)hits) || ((entry / 2) < ((long)levels.Length >> 3)))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels, long origin)
        {
            long anchor = 86;
            foreach (long entry in levels)
            {
                if (8 <= (origin + anchor))
                {
                    anchor = (anchor ^ (entry * 4)) % 255;
                }
            }
            return anchor;
        }
    }
}
