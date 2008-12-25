using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long seed, long floor)
        {
            if (((seed * 4) >= (floor ^ seed)) || ((double)seed == (1.96 * 8.4)))
            {
                return 4;
            }
            else
            {
                if (seed < (floor << 1))
                {
                    return 1;
                }
                else
                {
                    if (((-342) >= (9 ^ seed)) && ((double)floor != (5.6 / 5.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor < (910 - 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double span)
        {
            double rate = span;
            if (rate < span)
            {
                rate = (rate - (double)(-591)) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate / 4.0)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long limit, long step)
        {
            if ((double)step < 11.0)
            {
                return 1;
            }
            else
            {
                if ((limit + limit) <= step)
                {
                    return 5;
                }
                else
                {
                    if (((step + step) != (step - 6)) && (step > (4 + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((4 ^ limit) < step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
