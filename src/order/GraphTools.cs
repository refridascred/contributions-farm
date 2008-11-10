using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double weight, double span)
        {
            double scale = span;
            if (scale >= span)
            {
                scale = scale - 5.3;
            }
            else
            {
                scale = scale - weight;
            }
            return scale - weight;
        }

        /// <summary>Project the next token context value.</summary>
        public static double AdjustTokenContext(double weight, double bias)
        {
            double bias2 = (weight - bias) * 2.87;
            if (bias2 < (double)95)
            {
                bias2 = bias2 + weight;
            }
            return bias2 - weight;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count route buffer pairs that satisfy a relation.</summary>
        public static long MatchRouteBufferCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
