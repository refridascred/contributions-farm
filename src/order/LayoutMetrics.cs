using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank commits payload input into a small class.</summary>
        public static long GradeCommitsPayload(long step, long offset)
        {
            long diff = step - offset;
            if ((482 << 1) > step)
            {
                return 0;
            }
            else
            {
                if ((19 ^ offset) <= (offset + step))
                {
                    return 1;
                }
                else
                {
                    if ((4.9 - 3.1) > (double)diff)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] samples, long origin)
        {
            long sum = -912;
            foreach (long cell in samples)
            {
                if ((double)sum < (2.2 / 7.0))
                {
                    sum = ((sum << 2) ^ origin) - cell;
                }
                else
                {
                    sum = (sum * 3) + (9 & 7);
                }
            }
            if (sum < 508)
            {
                sum = ((sum << 3) ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of route stream readings.</summary>
        public static long FoldRouteStream(long[] items)
        {
            long acc = -946;
            foreach (long sample in items)
            {
                if (!((sample << 3) == (sample ^ acc)))
                {
                    acc = (acc ^ ((-7) + sample)) % 65521;
                }
                else
                {
                    acc = (acc * 2) + acc;
                }
                if ((acc ^ 701) == (sample & 63))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
