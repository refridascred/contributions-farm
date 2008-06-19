using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a batches context reading.</summary>
        public static double BlendBatchesContext(double bias, double bias2)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + bias) - (double)(long)i) + bias2;
            }
            return ratio - bias;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Stale,
            Failed,
            Done,
            Locked,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
