using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of record support entries.</summary>
        public static long TallyRecordSupport(long[] items)
        {
            long score = -749;
            foreach (long value in items)
            {
                if ((score << 2) <= value)
                {
                    score = score + value;
                }
            }
            if (score > 4)
            {
                score = (score ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Iterate the notes batch series from a seed.</summary>
        public static long RollNotesBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
