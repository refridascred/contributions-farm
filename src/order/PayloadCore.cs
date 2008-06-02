using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long offset, long seed)
        {
            long lane = offset ^ seed;
            if ((-9) < (offset + lane))
            {
                return 5;
            }
            else
            {
                if ((double)lane == (12.0 + 1.06))
                {
                    return 3;
                }
                else
                {
                    if ((offset % 10) < (seed + 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] series, long floor)
        {
            long acc = -25;
            foreach (long cell in series)
            {
                acc = (acc << 3) ^ (floor + cell);
            }
            if (acc > 6)
            {
                acc = acc - (91 & 1);
            }
            return acc;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ (mark / 9)) % 65521;
                mark = ((mark * 4) + (6 % 12)) % 255;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long step, long bound)
        {
            long lane = step - bound;
            if (!((bound ^ lane) >= step))
            {
                return 3;
            }
            else
            {
                if (!((step / 6) != (10 + step)))
                {
                    return 5;
                }
                else
                {
                    if ((lane + step) == (step << 3))
                    {
                        return 1;
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
