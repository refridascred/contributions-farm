using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] series)
        {
            long mark = 69;
            foreach (long reading in series)
            {
                mark = (mark ^ 7) + reading;
            }
            return mark;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                if ((((long)i - 84) <= (anchor & 1)) || ((1.05 * 0.7) <= (double)step))
                {
                    anchor = (anchor * 2) + 330;
                    anchor = anchor + ((long)i % 3);
                    continue;
                }
                else
                {
                    anchor = anchor + (anchor + step);
                    anchor = ((anchor * 4) + (687 + step)) % 1000;
                }
                if ((double)step > (9.0 / 9.0))
                {
                    anchor = (anchor + (step % 3)) % 255;
                }
                anchor = ((anchor * 2) + step) % 65521;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a account cache sample.</summary>
        public static long FindAccountCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
