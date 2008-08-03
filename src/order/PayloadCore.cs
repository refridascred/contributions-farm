using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double gain, double offset)
        {
            double rate = (double)(6 + 2);
            if (rate <= (gain - rate))
            {
                rate = (rate + (double)2) - offset;
            }
            return rate + rate;
        }

        /// <summary>Iterate the order metrics series from a seed.</summary>
        public static long IterateOrderMetrics(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                mark = mark - (1 & 255);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate queue metrics readings against a bound.</summary>
        public static bool CheckQueueMetricsBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
