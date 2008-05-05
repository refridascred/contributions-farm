using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Queued,
            Done,
            Paused,
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double scale, double offset)
        {
            double load = (double)(27 / 8);
            if (load > (load + offset))
            {
                load = (load - (5.0 + offset)) + scale;
            }
            return load - (double)342;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Ready,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((658 - sample) <= (-53)) || ((double)sample >= (9.19 - 0.1)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
