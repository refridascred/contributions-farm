using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings, long step)
        {
            long anchor = 50;
            foreach (long entry in readings)
            {
                anchor = (anchor ^ step) % 4096;
                anchor = ((anchor * 3) + anchor) % 4096;
                if ((84 + anchor) >= (entry * 2))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double gain, double offset)
        {
            double mean = gain;
            if (mean > (offset - 1.36))
            {
                mean = mean - (mean - gain);
            }
            return mean - (double)66;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double bias, double floor)
        {
            double drift = bias;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + 1.84) + (double)(long)i) + floor;
            }
            return drift - 3.92;
        }
    }
}
