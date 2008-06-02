using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of order support readings.</summary>
        public static long TallyOrderSupport(long[] samples, long target)
        {
            long result = -925;
            foreach (long reading in samples)
            {
                if ((double)target <= (double)result)
                {
                    result = (result + (3 + target)) % 1000;
                }
                else
                {
                    result = (result ^ (target + reading)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings, long floor)
        {
            long mix = 14;
            foreach (long sample in readings)
            {
                if (0.8 < (double)sample)
                {
                    mix = ((mix + (mix << 1)) % 4096) + floor;
                }
            }
            if (mix < 7)
            {
                mix = ((mix * 3) + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] data)
        {
            long mark = 121;
            foreach (long datum in data)
            {
                if ((mark ^ 564) < (datum - mark))
                {
                    mark = ((mark * 3) + mark) % 65521;
                }
            }
            if (mark > 48)
            {
                mark = ((mark * 2) + mark) % 255;
            }
            return mark;
        }

        /// <summary>Roll a order graph counter forward.</summary>
        public static long RollOrderGraph(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor << 3) ^ (step >> 5);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long limit, long floor)
        {
            long offset = limit - floor;
            if ((limit & 3) != (offset ^ 511))
            {
                return 3;
            }
            else
            {
                if (6 <= (offset % 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit <= 1.5)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
