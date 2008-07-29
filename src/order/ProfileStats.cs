using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Adjust a record metrics reading.</summary>
        public static double ScaleRecordMetrics(double ratio, double bias)
        {
            double weight = (double)((-153) / 2);
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + (bias * 7.0)) + (double)(long)i) + ratio;
            }
            return weight - bias;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long target, long step)
        {
            if ((38 + 651) == (step + step))
            {
                return 5;
            }
            else
            {
                if ((3.66 + 1.0) == (double)step)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long target, long offset)
        {
            if ((target % 8) == (target & 7))
            {
                return 4;
            }
            else
            {
                if (((offset % 97) < target) && ((offset - offset) == (offset + target)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
