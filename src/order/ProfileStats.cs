using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank record batches input into a small class.</summary>
        public static long GradeRecordBatches(long offset, long origin)
        {
            long next = offset ^ origin;
            if ((double)next < 6.0)
            {
                return 5;
            }
            else
            {
                if ((32 >> 5) < (next & 63))
                {
                    return 7;
                }
                else
                {
                    if (856 < origin)
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

        /// <summary>Check that every cluster queue entry stays within the limit.</summary>
        public static bool VerifyClusterQueueBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of window commits entries.</summary>
        public static long DigestWindowCommits(long[] levels)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                score = (score << 3) ^ (cell & 255);
            }
            if (score > 2)
            {
                score = (score + ((long)levels.Length / 4)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] items)
        {
            long mix = -67;
            foreach (long item in items)
            {
                if ((item + mix) > (mix * 4))
                {
                    mix = (mix << 3) ^ item;
                }
                if (((item / 5) < (item % 5)) && ((mix >> 2) >= mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
