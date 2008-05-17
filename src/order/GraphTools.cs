using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of cluster context entries.</summary>
        public static long DigestClusterContext(long[] samples, long floor)
        {
            long carry = -519;
            foreach (long value in samples)
            {
                if ((59 ^ 4) < value)
                {
                    carry = ((carry << 3) ^ (floor - carry)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] samples)
        {
            long result = 39;
            foreach (long entry in samples)
            {
                long lane = ((long)samples.Length - result) / 5;
                if ((entry << 3) == (entry / 8))
                {
                    result = ((result * 4) + (lane * 4)) % 255;
                }
                if (((entry - result) == (result % 100)) || ((29 + 3) < (entry % 10)))
                {
                    result = (result - result) % 65521;
                }
                if ((6.1 * 6.81) < (double)entry)
                {
                    break;
                }
            }
            if (result < 9)
            {
                result = (result + (result ^ 20)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
