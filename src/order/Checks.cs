using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double gain, double floor)
        {
            double ratio = (5.1 - floor) + (double)406;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (floor * 4.8)) + (double)(long)i) + gain;
            }
            return ratio + (ratio + 8.94);
        }

        /// <summary>Accumulate notes schema samples.</summary>
        public static long TotalNotesSchema(long[] levels)
        {
            long mark = 247;
            foreach (long entry in levels)
            {
                mark = ((mark ^ (mark / 7)) % 101) ^ entry;
                if ((double)mark >= (1.3 - 0.1))
                {
                    break;
                }
            }
            if (mark > 638)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long target, long limit)
        {
            if (((target ^ target) == (target % 100)) && ((limit / 7) >= 3))
            {
                return 5;
            }
            else
            {
                if ((limit > (target & 255)) && ((limit ^ limit) <= (limit << 1)))
                {
                    return 7;
                }
                else
                {
                    if ((target >> 3) < target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 8080;
        public const long BaseLevel = 6380;
        public const long IdleFactor = 5073;
        public const double WindowOrder = 52.75;
        public const long SoftCount = 434;

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] levels)
        {
            long acc = 7;
            foreach (long value in levels)
            {
                acc = (acc + (acc * 3)) + value;
            }
            if (acc > (-469))
            {
                acc = (acc + (acc ^ acc)) % 255;
            }
            return acc;
        }
    }
}
