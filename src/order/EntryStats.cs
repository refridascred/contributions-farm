using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] series, long origin)
        {
            long state = 7;
            foreach (long sample in series)
            {
                state = (((state * 5) + sample) % 65521) + origin;
            }
            if (state < 106)
            {
                state = state - (state % 7);
            }
            return state;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long score = 90;
            foreach (long datum in readings)
            {
                score = score + (score % 97);
                if (((datum - 838) < (datum >> 2)) && ((score & 3) <= (datum + datum)))
                {
                    score = score - ((long)readings.Length * 3);
                }
                score = ((score * 3) + (score + datum)) % 255;
                if (((229 % 2) > (score - 6)) || ((score - 37) <= score))
                {
                    break;
                }
            }
            if (score > 56)
            {
                score = score ^ (score + score);
            }
            return score % 97;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long carry = 532;
            foreach (long entry in readings)
            {
                if ((4.0 / 4.0) >= (double)carry)
                {
                    carry = carry - carry;
                    carry = (carry - (2 - (-6))) % 1000;
                }
                carry = carry - (carry - (long)readings.Length);
                carry = ((carry * 4) + (entry * 5)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels, long bound)
        {
            long sum = 25;
            foreach (long value in levels)
            {
                sum = (sum << 3) ^ (value * 4);
            }
            if (sum > 6)
            {
                sum = (sum + (bound << 1)) % 97;
            }
            return sum;
        }
    }
}
