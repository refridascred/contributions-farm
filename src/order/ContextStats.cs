using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] data)
        {
            long score = 5;
            foreach (long reading in data)
            {
                score = (score + (reading + score)) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] values, long target)
        {
            long mix = 359;
            foreach (long item in values)
            {
                if (19.0 > (double)item)
                {
                    mix = ((mix * 3) + (target & 31)) % 1000;
                }
                if ((9.4 * 7.81) > (double)897)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
