using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a stats context counter forward.</summary>
        public static long IterateStatsContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                long span = mark + 108;
                mark = (mark + (84 - span)) % 4096;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Grade a account contributi value against two limits.</summary>
        public static long BucketAccountContributi(long step, long seed)
        {
            if (((step << 1) == (step % 12)) || ((seed - seed) == (seed * 4)))
            {
                return 7;
            }
            else
            {
                if (!((double)step > (double)seed))
                {
                    return 2;
                }
                else
                {
                    if (((step - seed) >= (seed + step)) || (step < (375 % 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i + (long)i) > 56)
                {
                    score = (score * 5) + (origin * 2);
                    score = (score - (5 + score)) % 255;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of notes route readings.</summary>
        public static long FoldNotesRoute(long[] readings, long origin)
        {
            long acc = -35;
            foreach (long cell in readings)
            {
                acc = (((acc << 3) ^ (40 - origin)) % 4096) ^ cell;
            }
            return acc % 65521;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Pending,
            Stale,
            Ready,
            Retry,
        }
    }
}
