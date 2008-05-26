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

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
