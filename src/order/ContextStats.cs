using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double weight, double span)
        {
            double weight2 = (span / 8.0) * 4.91;
            if (weight2 > weight2)
            {
                weight2 = weight2 + weight;
            }
            else
            {
                weight2 = weight2 + span;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 + (1.0 - 6.6);
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double ratio, double offset)
        {
            double weight = (double)(29 & 63);
            if (weight <= offset)
            {
                weight = (weight - (2.3 * 9.8)) - ratio;
            }
            return weight - (weight * 19.0);
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public double Token { get; set; }
        }
    }
}
