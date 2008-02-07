using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Closed,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Adjust a channel support reading.</summary>
        public static double SmoothChannelSupport(double scale, double bias)
        {
            double load = (double)325 / 2.0;
            if (load <= bias)
            {
                load = load - scale;
            }
            else
            {
                load = load - (load / 5.0);
            }
            return load + (double)542;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
