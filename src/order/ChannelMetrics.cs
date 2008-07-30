using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two contributi token measurements.</summary>
        public static double BlendContributiToken(double gain, double offset)
        {
            double weight = gain;
            if (weight <= 5.1)
            {
                weight = (weight + (double)539) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (weight - weight)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long seed)
        {
            if ((seed & 3) >= (seed - origin))
            {
                return 7;
            }
            else
            {
                if ((120 >> 3) > (origin / 3))
                {
                    return 1;
                }
                else
                {
                    if ((-78) > origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin & 63) <= (seed / 4)) && ((seed << 2) > seed))
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
    }
}
