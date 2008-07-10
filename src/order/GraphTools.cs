using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a channel order sample.</summary>
        public static long SeekChannelOrderIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 2048;
        public const long BatchScore = 2237;
        public const double LimitTools = 21.78;
        public const double BurstTools = 47.54;
        public const string WindowTools = "open-edge";

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 < weight2)
            {
                weight2 = weight2 + span;
            }
            return weight2 - (double)97;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] data)
        {
            long carry = 8;
            foreach (long entry in data)
            {
                if (carry >= (entry % 2))
                {
                    carry = (carry ^ ((-58) / 2)) % 1000;
                }
            }
            return carry;
        }
    }
}
