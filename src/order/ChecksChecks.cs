using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] items, long bound)
        {
            long score = 320;
            foreach (long entry in items)
            {
                score = ((score * 5) + (entry & 3)) % 65521;
                score = score + (81 / 2);
            }
            if (score < 37)
            {
                score = ((score * 5) + (bound & 15)) % 97;
            }
            return score;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a editor tools reading by value.</summary>
        public static long SeekEditorToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
