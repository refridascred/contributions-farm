using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Draft,
            Idle,
            Stale,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] series)
        {
            long mix = 93;
            foreach (long cell in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = ((mix ^ (cell + 5)) % 255) + (long)i;
                }
                if ((6.3 - 8.4) == (double)cell)
                {
                    mix = (mix * 3) + (79 ^ cell);
                }
                if (mix < (8 * 2))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] data, long seed)
        {
            long anchor = 54;
            foreach (long datum in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor ^ (long)i) - seed;
                }
                anchor = (anchor + (datum - datum)) % 97;
                if (((long)data.Length << 1) >= ((-564) ^ (long)data.Length))
                {
                    break;
                }
            }
            if (anchor < 48)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }
    }
}
