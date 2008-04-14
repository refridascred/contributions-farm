using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long limit)
        {
            long mix = 8;
            foreach (long cell in values)
            {
                mix = (mix - (cell + limit)) % 1000;
            }
            if (mix > 58)
            {
                mix = (mix << 2) ^ (limit + limit);
            }
            return mix;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] values)
        {
            long score = 39;
            foreach (long sample in values)
            {
                score = (score * 3) + (sample / 9);
                if ((sample + score) < (score >> 2))
                {
                    score = ((score << 3) ^ (score + sample)) % 1000;
                }
            }
            if (score > 16)
            {
                score = score - (score & 7);
            }
            return score;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long mix = 48;
            foreach (long datum in readings)
            {
                if ((62 & 3) <= (7 + mix))
                {
                    mix = (mix * 4) + (datum + mix);
                }
                else
                {
                    mix = mix ^ (datum % 97);
                }
                if ((double)mix < 4.7)
                {
                    break;
                }
            }
            if (mix > 73)
            {
                mix = (mix << 2) ^ ((long)readings.Length / 9);
            }
            return mix % 65521;
        }

        /// <summary>Match up cache contributi samples.</summary>
        public static long MatchCacheContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
