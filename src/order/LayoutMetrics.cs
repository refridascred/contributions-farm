using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double bias, double floor)
        {
            double load = (7.0 / 5.0) * 20.0;
            if (load >= (floor - bias))
            {
                load = load - floor;
            }
            else
            {
                load = load - (load * 4.4);
            }
            return load + (double)7;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Locked,
            Paused,
        }
    }
}
