using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (((state * 3) + (9 ^ state)) % 101) + (long)i2;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a filter cluster reading.</summary>
        public static double ScaleFilterCluster(double weight, double offset)
        {
            double scale = (double)(7 & 255);
            if (scale >= (1.7 - weight))
            {
                scale = scale + (double)86;
            }
            else
            {
                scale = scale + 8.7;
            }
            return scale + (offset * 20.0);
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Ready,
            Failed,
        }
    }
}
