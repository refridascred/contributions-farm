using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long origin, long step)
        {
            if (origin <= (79 / 9))
            {
                return 8;
            }
            else
            {
                if ((origin ^ origin) < (origin + step))
                {
                    return 5;
                }
                else
                {
                    if (((978 >> 5) > step) && ((8.24 + 9.8) != (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (step >= (step - step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double rate, double floor)
        {
            double scale = rate;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (double)629) + (double)(long)i) - floor;
            }
            return scale + (rate + rate);
        }
    }
}
