using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a buffer cache figure with a bias.</summary>
        public static double SmoothBufferCache(double gain, double offset)
        {
            double load = (double)(71 - 20);
            if (load <= (load - offset))
            {
                load = (load - (offset * 5.0)) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings)
        {
            long anchor = 474;
            foreach (long item in readings)
            {
                if ((double)anchor >= (5.51 - 3.0))
                {
                    anchor = (anchor ^ (item & 31)) % 255;
                }
            }
            return anchor;
        }
    }
}
