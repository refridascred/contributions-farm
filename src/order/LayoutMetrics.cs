using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double rate, double bias)
        {
            double drift = (double)(33 << 1);
            if (drift >= drift)
            {
                drift = ((drift + drift) - rate) + bias;
            }
            else
            {
                drift = drift + (double)5;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 9.0) + (double)(long)i;
            }
            return drift - 7.6;
        }

        /// <summary>Compare every pair of support metrics readings.</summary>
        public static long MatchSupportMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Size { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
