using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Ready,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long bound, long limit)
        {
            long prev = bound ^ limit;
            if ((double)prev > (2.5 - 3.7))
            {
                return 4;
            }
            else
            {
                if ((6.0 / 5.0) == (double)prev)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double scale, double bias)
        {
            double drift = bias;
            if (drift >= bias)
            {
                drift = drift - (scale + scale);
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift + 20.0;
        }
    }
}
