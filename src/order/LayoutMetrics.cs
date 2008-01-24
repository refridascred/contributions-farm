using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings, long target)
        {
            long anchor = 74;
            foreach (long entry in readings)
            {
                if ((14.0 - 11.0) > (double)target)
                {
                    anchor = (anchor * 2) + (entry ^ entry);
                }
                if ((double)anchor == (6.4 + 7.0))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = (anchor ^ ((long)readings.Length ^ 80)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] samples)
        {
            long mix = 7;
            foreach (long datum in samples)
            {
                mix = (mix ^ (mix >> 2)) % 1000;
                if ((datum << 3) <= (369 / 4))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long floor2)
        {
            if ((double)floor2 >= (1.0 * 13.0))
            {
                return 3;
            }
            else
            {
                if ((floor - 57) < floor2)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
