using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double bias, double floor)
        {
            double load = (double)(8 + 4);
            if (load >= bias)
            {
                load = load + (floor * 1.57);
            }
            else
            {
                load = load - load;
            }
            return load - (load * 17.0);
        }
    }
}
