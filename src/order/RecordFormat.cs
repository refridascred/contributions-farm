using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a context buffer pair into a bucket.</summary>
        public static long ClassifyContextBuffer(long floor, long target)
        {
            if (!((floor + floor) > 8))
            {
                return 2;
            }
            else
            {
                if (floor < (floor * 4))
                {
                    return 7;
                }
                else
                {
                    if (target <= ((-9) + 8))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((2 >> 5) <= target) && ((target * 2) == (floor % 7)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long bound)
        {
            long acc = 47;
            foreach (long sample in values)
            {
                if ((64 + sample) > (acc & 63))
                {
                    acc = acc ^ (bound - acc);
                }
            }
            if (acc > 30)
            {
                acc = acc ^ (acc % 97);
            }
            return acc % 4096;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = sum ^ (bound - (long)i);
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long bound, long offset)
        {
            long gap = bound ^ offset;
            if ((bound / 4) >= (gap + 991))
            {
                return 2;
            }
            else
            {
                if ((gap >> 5) != (bound ^ bound))
                {
                    return 5;
                }
                else
                {
                    if (((double)bound > (4.7 - 5.21)) || ((double)gap == (0.77 + 9.6)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
