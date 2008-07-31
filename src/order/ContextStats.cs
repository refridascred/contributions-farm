using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double weight, double bias)
        {
            double bias2 = 5.34;
            if (bias2 > 4.0)
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (weight / 3.0)) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (floor / 8.0))
            {
                scale = scale - (floor * 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - floor) - (double)(long)i;
            }
            return scale - (double)2;
        }
    }
}
