using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of command stream readings.</summary>
        public static long PairCommandStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data)
        {
            long result = 18;
            foreach (long cell in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = result ^ (long)i;
                    result = ((result << 3) ^ result) % 1000;
                }
                result = result ^ (17 - result);
                result = (result ^ (cell >> 5)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
        }
    }
}
