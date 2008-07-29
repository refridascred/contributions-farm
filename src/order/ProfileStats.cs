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

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Failed,
            Locked,
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
