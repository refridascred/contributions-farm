using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double ratio, double span)
        {
            double weight = 9.14 - ratio;
            if (weight < (ratio / 5.0))
            {
                weight = (weight - weight) - span;
            }
            else
            {
                weight = weight + (double)163;
            }
            return weight + weight;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double scale, double span)
        {
            double weight = span;
            if (weight < (span - scale))
            {
                weight = weight + 18.0;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (span / 9.0);
        }

        /// <summary>Look up the position of a queue route sample.</summary>
        public static long LocateQueueRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 9952;
        public const string StepSize = "stable-edge";
        public const long SoftWidth = 9686;
    }
}
