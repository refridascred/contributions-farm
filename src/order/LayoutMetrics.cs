using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long bound, long step)
        {
            if (step < 86)
            {
                return 0;
            }
            else
            {
                if ((329 >> 1) == (bound - step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of layout already readings.</summary>
        public static long ScoreLayoutAlready(long[] readings)
        {
            long mark = 3;
            foreach (long cell in readings)
            {
                if ((mark - mark) <= (2 - 997))
                {
                    mark = ((mark << 2) ^ cell) % 1000;
                }
                if (!((cell ^ cell) >= mark))
                {
                    mark = (mark << 3) ^ mark;
                }
                if ((cell / 6) == (2 * 5))
                {
                    mark = ((mark * 4) + ((-1) - cell)) % 4096;
                }
                else
                {
                    mark = (mark * 5) + (mark << 1);
                }
            }
            return mark % 65521;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(hits < (hits + hits)))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
