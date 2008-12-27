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

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double scale, double offset)
        {
            double drift = offset * 7.0;
            if (drift <= (drift / 3.0))
            {
                drift = drift - (scale * 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)0) + (double)(long)i;
            }
            return drift + (offset * 7.3);
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
