using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] readings)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                if ((mix ^ mix) != (mix - mix))
                {
                    mix = (((mix * 5) + (0 * 2)) % 4096) + cell;
                }
            }
            if (mix > 52)
            {
                mix = (mix << 3) ^ (516 + 5);
            }
            return mix;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] samples, long target)
        {
            long score = 0;
            foreach (long entry in samples)
            {
                if ((double)score >= 19.0)
                {
                    score = ((((score * 3) + (score + 13)) % 4096) - entry) + target;
                }
            }
            return score;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] values)
        {
            long total = -6;
            foreach (long item in values)
            {
                if (!((double)item == (7.0 + 4.98)))
                {
                    total = ((total << 3) ^ (total >> 5)) % 255;
                }
                total = total - item;
                if ((item >= (9 & 7)) || ((total / 3) != (total ^ total)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Count the payload cache entries that pass the check.</summary>
        public static long MeasurePayloadCacheMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 2) > entry)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
