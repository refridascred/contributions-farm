using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double gain, double floor)
        {
            double mean = (double)(3 / 6);
            if (mean < (mean + mean))
            {
                mean = mean + (floor * 15.0);
            }
            else
            {
                mean = mean + (double)(-9);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (gain - mean)) + (double)(long)i;
            }
            return mean + (mean / 8.0);
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Done,
            Ready,
        }
    }
}
