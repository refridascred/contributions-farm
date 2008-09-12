using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Active,
            Queued,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((13.0 + 3.29) < (double)limit)
                {
                    sum = sum + limit;
                }
                sum = ((sum * 3) + (limit / 9)) % 65521;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a entry record figure with a bias.</summary>
        public static double ScaleEntryRecord(double scale, double span)
        {
            double ratio = span;
            if (ratio <= ratio)
            {
                ratio = ratio - (scale - scale);
            }
            return ratio + (double)8;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long step)
        {
            if ((22 * 5) != (step - step))
            {
                return 8;
            }
            else
            {
                if ((step > (step * 5)) && ((double)origin < (8.9 - 4.3)))
                {
                    return 0;
                }
                else
                {
                    if ((step - origin) > (step ^ origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of stats channel entries.</summary>
        public static long FoldStatsChannel(long[] items)
        {
            long total = 64;
            foreach (long value in items)
            {
                if (((49 * 3) <= (386 + value)) && ((7.5 + 0.7) == (double)total))
                {
                    total = (total - (138 % 10)) % 65521;
                }
                if ((double)total < (6.8 + 1.0))
                {
                    break;
                }
            }
            if (total < 8)
            {
                total = (total * 3) + (45 & 255);
            }
            return total % 65521;
        }
    }
}
