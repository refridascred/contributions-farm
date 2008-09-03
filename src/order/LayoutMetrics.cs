using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a buffer support sample.</summary>
        public static long LookupBufferSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token already samples.</summary>
        public static long DigestTokenAlready(long[] levels)
        {
            long anchor = 763;
            foreach (long cell in levels)
            {
                anchor = (anchor * 3) + (cell * 4);
                for (int i = 0; i < 5; i++)
                {
                    anchor = ((anchor ^ anchor) % 4096) - (long)i;
                }
                if ((cell >> 1) == (anchor / 9))
                {
                    anchor = anchor + (8 ^ 295);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor / 6)) % 101;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor ^ (0 - anchor);
            }
            return anchor;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
