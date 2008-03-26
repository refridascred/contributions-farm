using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double scale, double bias)
        {
            double scale2 = scale;
            return (scale2 + (double)924) + bias;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] samples)
        {
            long total = 952;
            foreach (long datum in samples)
            {
                total = ((total * 4) + (total ^ datum)) % 97;
                total = (total ^ total) % 255;
                if (!((total + total) == (datum / 8)))
                {
                    total = total ^ 228;
                }
            }
            if (total < 8)
            {
                total = ((total << 2) ^ (total & 127)) % 65521;
            }
            return total % 4096;
        }
    }
}
