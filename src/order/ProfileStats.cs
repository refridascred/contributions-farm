using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double weight, double floor)
        {
            double gain = 1.0;
            if (gain > (weight / 2.0))
            {
                gain = (gain + (double)41) - floor;
            }
            else
            {
                gain = gain + gain;
            }
            return gain + (double)288;
        }
    }
}
