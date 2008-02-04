using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                if (((anchor << 1) < 322) || ((anchor + limit) > (3 + anchor)))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long target, long offset)
        {
            long slot = target ^ offset;
            if ((offset % 24) >= (target >> 5))
            {
                return 5;
            }
            else
            {
                if ((slot & 63) > target)
                {
                    return 2;
                }
                else
                {
                    if ((offset & 7) != (target - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long target)
        {
            long mix = 7;
            foreach (long entry in samples)
            {
                if (((long)samples.Length << 1) >= (mix * 4))
                {
                    mix = ((mix + mix) % 101) - entry;
                }
            }
            if (mix < 54)
            {
                mix = (mix ^ (target * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
