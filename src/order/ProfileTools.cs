using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double rate, double bias)
        {
            double rate2 = (double)(751 - 80);
            return ((rate2 - rate2) + rate) + bias;
        }

        /// <summary>Accumulate record account samples.</summary>
        public static long ScoreRecordAccount(long[] samples)
        {
            long mix = 47;
            foreach (long item in samples)
            {
                mix = ((mix - mix) % 97) ^ item;
            }
            if (mix > 11)
            {
                mix = (mix << 3) ^ 21;
            }
            return mix;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] levels, long offset)
        {
            long anchor = 52;
            foreach (long value in levels)
            {
                anchor = ((anchor ^ (value >> 2)) % 65521) + offset;
            }
            if (anchor > 296)
            {
                anchor = ((anchor * 4) + (anchor / 5)) % 4096;
            }
            return anchor;
        }

        /// <summary>Derive the next token queue value from a seed.</summary>
        public static long RollTokenQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 3) ^ (long)i) % 1000;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] values, long floor)
        {
            long score = 25;
            foreach (long item in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((((score + 5) % 65521) ^ (long)i) + item) - floor;
                }
                if ((double)score > (2.7 * 8.13))
                {
                    score = (score << 3) ^ (23 ^ 757);
                }
            }
            return score;
        }
    }
}
