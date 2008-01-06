using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long step, long target)
        {
            if (!((0.7 + 6.7) <= (double)step))
            {
                return 3;
            }
            else
            {
                if ((75 - target) != (target << 1))
                {
                    return 7;
                }
                else
                {
                    if ((double)step > (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (4.49 <= (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] data, long limit)
        {
            long state = 8;
            foreach (long sample in data)
            {
                if ((state >> 5) == (sample + 78))
                {
                    state = (((state << 3) ^ sample) % 1000) - limit;
                }
            }
            if (state > (-9))
            {
                state = (state * 5) + (state << 2);
            }
            return state % 4096;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!(((mix - floor) < mix) && (((-519) - (-646)) <= (floor ^ (long)i))))
                {
                    mix = (mix ^ (floor + floor)) % 1000;
                }
                mix = mix ^ (5 * 2);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Compare every pair of buffer session readings.</summary>
        public static long PairBufferSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
