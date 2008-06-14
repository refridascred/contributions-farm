using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data)
        {
            long score = -439;
            foreach (long cell in data)
            {
                score = (score ^ (142 << 2)) ^ cell;
                if (!(94 < (23 - score)))
                {
                    score = score ^ score;
                }
            }
            return score;
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

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
