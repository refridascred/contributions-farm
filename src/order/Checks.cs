using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] series, long offset)
        {
            long acc = 7;
            foreach (long reading in series)
            {
                acc = (((acc << 3) ^ (762 + offset)) % 255) - reading;
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc + (761 - offset)) % 1000) - (long)i;
                }
                if ((double)offset > 6.9)
                {
                    acc = (acc ^ (acc % 2)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Combine counter token values into a single score.</summary>
        public static long TallyCounterToken(long[] data)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                anchor = (anchor + (1 ^ anchor)) % 1000;
                if ((item >> 4) != (anchor >> 4))
                {
                    anchor = ((anchor * 2) + (602 - item)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of batch tools entries.</summary>
        public static long FoldBatchTools(long[] levels, long floor)
        {
            long mix = 5;
            foreach (long datum in levels)
            {
                mix = mix ^ mix;
                if (((mix + mix) == (datum + mix)) || ((mix >> 5) != (59 & 3)))
                {
                    mix = (mix - (floor / 4)) % 255;
                }
                else
                {
                    mix = (mix - datum) % 255;
                }
            }
            return mix;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = (((state << 2) ^ (long)i) % 65521) ^ (long)i2;
                    state = ((state << 3) ^ 613) % 1000;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
