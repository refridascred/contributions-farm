using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double ratio, double floor)
        {
            double load = ratio;
            if (load >= (ratio / 4.0))
            {
                load = load - (double)7;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - floor) - (double)(long)i;
            }
            return load - (double)556;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Rank { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
