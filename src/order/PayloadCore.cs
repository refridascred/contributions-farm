using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] data)
        {
            long anchor = -41;
            foreach (long value in data)
            {
                anchor = (anchor ^ anchor) ^ value;
            }
            if (anchor < 141)
            {
                anchor = anchor + (anchor / 8);
            }
            return anchor;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double scale, double floor)
        {
            double load = 11.0 / 5.0;
            if (load > (scale - scale))
            {
                load = load - floor;
            }
            else
            {
                load = load - (floor + load);
            }
            return load - (scale / 4.0);
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
