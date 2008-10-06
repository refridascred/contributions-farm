using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double bias, double floor)
        {
            double bias2 = (double)(421 - 738);
            if (bias2 > floor)
            {
                bias2 = bias2 + (bias + bias2);
            }
            else
            {
                bias2 = bias2 - (double)(-454);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (8.3 * 0.17)) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Check that every already commits entry stays within the limit.</summary>
        public static bool CheckAlreadyCommitsBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
