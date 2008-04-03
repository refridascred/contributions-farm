using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Failed,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] values)
        {
            long mix = 1;
            foreach (long entry in values)
            {
                if (8 < (mix ^ mix))
                {
                    mix = (mix ^ (mix + mix)) % 97;
                }
                else
                {
                    mix = (mix ^ (entry >> 5)) % 1000;
                }
            }
            return mix % 4096;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double weight, double offset)
        {
            double ratio = weight;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (offset + offset)) + (double)(long)i;
            }
            return ratio + 4.1;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Synced,
            Failed,
            Pending,
            New,
        }
    }
}
