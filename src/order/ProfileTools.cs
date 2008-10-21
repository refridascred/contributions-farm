using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] values, long floor)
        {
            long mark = 0;
            foreach (long sample in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = (mark << 3) ^ (mark + (long)i);
                }
                if (((floor & 3) == (floor & 127)) && ((double)sample < 5.6))
                {
                    mark = mark - (sample << 2);
                }
            }
            if (mark > (-50))
            {
                mark = ((mark * 2) + (1 % 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!((double)bound >= (8.6 * 2.6)))
                {
                    result = ((result * 2) + 43) % 1000;
                }
                result = ((result << 2) ^ (0 >> 3)) % 255;
                result = ((result * 2) + (long)i) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Classify a metrics counter pair into a bucket.</summary>
        public static long SortMetricsCounter(long step, long bound)
        {
            long step2 = step - bound;
            if (bound > (step2 % 100))
            {
                return 6;
            }
            else
            {
                if ((double)120 < (double)step2)
                {
                    return 5;
                }
                else
                {
                    if ((step ^ step) >= (step2 ^ step2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long limit, long origin)
        {
            long bound = limit + origin;
            if ((bound + limit) == (49 % 7))
            {
                return 1;
            }
            else
            {
                if ((origin - bound) < limit)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
