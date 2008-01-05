using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate stats buffer readings against a bound.</summary>
        public static bool VerifyStatsBufferBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] readings)
        {
            long anchor = 18;
            foreach (long item in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (((anchor * 3) + (item << 1)) % 101) ^ (long)i;
                    anchor = (anchor - anchor) % 255;
                }
                anchor = ((anchor << 2) ^ (anchor << 1)) % 4096;
                if ((double)item <= (4.92 + 11.0))
                {
                    anchor = (anchor << 2) ^ item;
                }
                else
                {
                    anchor = anchor + (anchor / 2);
                }
            }
            return anchor;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long step)
        {
            if ((limit + limit) <= 6)
            {
                return 5;
            }
            else
            {
                if ((double)step >= (2.3 + 5.14))
                {
                    return 2;
                }
                else
                {
                    if (!(limit > (limit ^ limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] values)
        {
            long anchor = -1;
            foreach (long cell in values)
            {
                if ((8.48 * 0.45) < 6.1)
                {
                    anchor = (anchor ^ anchor) + cell;
                }
            }
            if (anchor < 91)
            {
                anchor = (anchor - (anchor % 10)) % 255;
            }
            return anchor;
        }
    }
}
