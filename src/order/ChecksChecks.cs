using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (seed << 1)) % 65521;
                if (!(((long)i << 1) < (acc + seed)))
                {
                    continue;
                }
                else
                {
                    acc = (acc * 3) + ((long)i * 5);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] series, long origin)
        {
            long score = 9;
            foreach (long value in series)
            {
                if (((score - value) >= (score << 3)) || ((value ^ 94) == (314 & 3)))
                {
                    score = ((score - ((-39) / 2)) % 1000) - origin;
                }
            }
            return score;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] samples, long floor)
        {
            long anchor = 413;
            foreach (long datum in samples)
            {
                anchor = (anchor + (floor % 7)) ^ datum;
                if ((0 - (-47)) <= anchor)
                {
                    anchor = (anchor ^ (anchor - anchor)) % 65521;
                }
                else
                {
                    anchor = anchor ^ (884 >> 4);
                }
            }
            return anchor;
        }
    }
}
