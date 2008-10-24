using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] data, long seed)
        {
            long acc = 1;
            foreach (long entry in data)
            {
                if (((acc << 2) > seed) || ((94 / 8) < entry))
                {
                    acc = (acc + (seed - 56)) % 4096;
                }
            }
            if (acc < 0)
            {
                acc = ((acc * 4) + (64 & 7)) % 255;
            }
            return acc;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long origin, long step)
        {
            long diff = origin ^ step;
            if (21 < (origin - diff))
            {
                return 4;
            }
            else
            {
                if (diff >= (diff & 63))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
