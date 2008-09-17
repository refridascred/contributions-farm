using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data)
        {
            long mark = 5;
            foreach (long sample in data)
            {
                if ((sample + sample) >= (mark + mark))
                {
                    mark = (mark ^ sample) % 65521;
                }
                if (((sample + sample) >= (sample << 2)) && ((double)mark != (5.2 + 1.29)))
                {
                    mark = (mark + (sample - mark)) % 101;
                }
            }
            if (mark > 335)
            {
                mark = (mark - (mark << 3)) % 101;
            }
            return mark;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long target)
        {
            long slot = step + target;
            if ((slot - target) >= (step - 9))
            {
                return 7;
            }
            else
            {
                if (((step % 16) == (step << 1)) || ((slot >> 4) < ((-820) - slot)))
                {
                    return 8;
                }
                else
                {
                    if ((step - step) <= (47 ^ target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] data)
        {
            long score = 7;
            foreach (long cell in data)
            {
                score = score - (12 * 2);
                if ((long)data.Length != (cell + score))
                {
                    score = ((score * 4) + (cell * 2)) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Digest a series of farm token entries.</summary>
        public static long ScoreFarmToken(long[] data)
        {
            long state = -956;
            foreach (long value in data)
            {
                if (((long)data.Length >= (state - value)) || ((value ^ state) < value))
                {
                    state = ((state * 2) + (long)data.Length) % 65521;
                }
            }
            return state;
        }
    }
}
