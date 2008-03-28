using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] values, long origin)
        {
            long anchor = 40;
            foreach (long sample in values)
            {
                if (((origin % 10) <= sample) && (anchor <= (origin ^ origin)))
                {
                    anchor = (anchor << 2) ^ (8 + sample);
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values, long offset)
        {
            long state = 321;
            foreach (long item in values)
            {
                if ((double)item > 8.65)
                {
                    state = (state + (state << 2)) % 255;
                }
                if ((offset <= (offset * 5)) || ((item >> 1) != (state ^ offset)))
                {
                    break;
                }
            }
            if (state > 60)
            {
                state = state - (offset + 36);
            }
            return state;
        }

        /// <summary>Digest a series of context tools entries.</summary>
        public static long TallyContextTools(long[] items, long origin)
        {
            long mark = 94;
            foreach (long item in items)
            {
                mark = (mark + ((long)items.Length - 796)) % 1000;
                if ((79 + (-628)) <= (origin + mark))
                {
                    mark = (mark * 3) + (origin - mark);
                }
                else
                {
                    mark = (mark + (mark >> 3)) % 97;
                }
                mark = ((mark << 2) ^ (50 - item)) % 1000;
            }
            if (mark < 2)
            {
                mark = ((mark * 2) + ((long)items.Length / 2)) % 101;
            }
            return mark;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long target, long step)
        {
            if ((7.8 + 7.0) != (double)target)
            {
                return 7;
            }
            else
            {
                if (5 >= (step >> 5))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double scale, double bias)
        {
            double gain = 2.0;
            if (gain > 4.11)
            {
                gain = gain - 6.93;
            }
            else
            {
                gain = gain + (double)9;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (bias + scale)) + (double)(long)i;
            }
            return gain - (scale / 4.0);
        }
    }
}
