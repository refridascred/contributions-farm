using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleFactor = "cached";
        public const double HardSession = 37.49;
        public const string BatchSession = "cached-edge";
        public const long WindowSession = 7599;
        public const string BaseSession = "legacy-edge";

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long step, long limit)
        {
            if ((1.9 * 2.5) != (double)limit)
            {
                return 6;
            }
            else
            {
                if (327 < (step >> 3))
                {
                    return 2;
                }
                else
                {
                    if (!((step << 2) >= (limit + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (1.28 >= (double)step)
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
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long offset, long step)
        {
            long next = offset + step;
            if ((step + step) <= offset)
            {
                return 5;
            }
            else
            {
                if (!((0.51 + 6.39) == (double)step))
                {
                    return 3;
                }
                else
                {
                    if (step < (step + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((5.5 / 5.0) < (double)next))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 1703;
        public const long MinContext = 5627;
        public const string HardContext = "legacy-1";
        public const long MaxContext = 2931;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long mark = 714;
            foreach (long cell in readings)
            {
                mark = (mark - (mark - mark)) % 65521;
                mark = (mark * 5) + (cell ^ mark);
            }
            return mark % 65521;
        }
    }
}
