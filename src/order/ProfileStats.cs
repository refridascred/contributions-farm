using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double weight, double bias)
        {
            double load = weight + (bias - weight);
            if (load > bias)
            {
                load = load - (double)(-1);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load + bias)) + (double)(long)i;
            }
            return load + (load * 6.7);
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long origin, long bound)
        {
            if (!((5.0 - 16.0) != (double)origin))
            {
                return 7;
            }
            else
            {
                if (((origin / 6) <= origin) || ((1.5 - 2.87) != (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound >= (8 + origin)) || (origin <= (1 + origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)1 == (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
