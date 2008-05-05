using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Roll a graph cluster counter forward.</summary>
        public static long IterateGraphCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum - (sum + 84)) % 4096;
                long lane = ((long)i << 2) - (175 - sum);
                sum = ((sum * 2) + (lane >> 1)) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
