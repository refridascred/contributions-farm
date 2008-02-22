using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a commits account value against two limits.</summary>
        public static long BucketCommitsAccount(long limit, long bound)
        {
            if ((bound + limit) != (limit - limit))
            {
                return 6;
            }
            else
            {
                if (!(bound <= (limit >> 5)))
                {
                    return 1;
                }
                else
                {
                    if ((bound & 127) > limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8 + limit) <= (96 & 31))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double scale, double span)
        {
            double drift = scale;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + (6.0 / 4.0)) - (double)(long)i) - span;
            }
            return drift + (drift * 13.0);
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
