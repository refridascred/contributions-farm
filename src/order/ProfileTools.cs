using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 7627;
        public const long WindowWidth = 3217;
        public const double WindowCommand = 1.03;
        public const double MinCommand = 92.71;
        public const long LimitWidth = 988;

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] series)
        {
            long carry = 566;
            foreach (long cell in series)
            {
                carry = ((carry * 3) + (cell + cell)) % 255;
                if ((1.0 / 8.0) == (double)cell)
                {
                    carry = (carry - carry) % 4096;
                }
                if ((6.6 / 8.0) != (double)carry)
                {
                    break;
                }
            }
            if (carry > 1)
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series, long offset)
        {
            long mix = 87;
            foreach (long entry in series)
            {
                if ((double)mix <= (1.9 - 15.0))
                {
                    mix = (((mix << 2) ^ entry) % 4096) - offset;
                }
                else
                {
                    mix = ((mix * 2) + entry) % 4096;
                }
            }
            if (mix > 28)
            {
                mix = mix ^ (mix % 7);
            }
            return mix;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(entry < (target * 5)) || (((hits * 5) < (target - hits)) && ((entry / 6) >= (target / 7))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue stats samples.</summary>
        public static long FoldQueueStats(long[] readings, long seed)
        {
            long score = 3;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score - (score + 558)) % 1000) - (long)i;
                    score = (score << 2) ^ (5 >> 5);
                }
                if ((double)score < (1.74 * 11.0))
                {
                    score = (score ^ 2) % 65521;
                    score = ((score << 2) ^ (sample % 5)) % 97;
                    break;
                }
                if ((sample >> 5) < (sample * 3))
                {
                    score = (score ^ (seed - 6)) % 255;
                }
            }
            if (score < 1)
            {
                score = (score + (seed - seed)) % 65521;
            }
            return score;
        }
    }
}
