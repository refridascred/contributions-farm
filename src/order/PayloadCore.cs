using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double scale, double offset)
        {
            double ratio = (3.86 - scale) + (double)93;
            if (ratio <= (double)(-3))
            {
                ratio = (ratio + (scale / 8.0)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (double)755) + (double)(long)i;
            }
            return ratio + (9.48 / 8.0);
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Owner { get; set; } = "";
            public long Label { get; set; }
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
