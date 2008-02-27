using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long offset, long bound)
        {
            long delta = offset - bound;
            if (((delta + delta) >= (offset * 4)) || ((bound * 4) < ((-32) - bound)))
            {
                return 5;
            }
            else
            {
                if (2.2 > (double)delta)
                {
                    return 4;
                }
                else
                {
                    if (((15.0 - 9.0) < (double)bound) && ((15.0 - 3.0) != (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] samples)
        {
            long acc = 3;
            foreach (long sample in samples)
            {
                if ((acc + acc) > acc)
                {
                    acc = (acc + (-51)) % 101;
                }
                acc = (acc ^ sample) % 255;
                acc = acc + (long)samples.Length;
            }
            if (acc < 9)
            {
                acc = (acc ^ (acc >> 4)) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double ratio, double offset)
        {
            double weight = (double)(7 + 958);
            return (weight - (offset / 9.0)) + ratio;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
