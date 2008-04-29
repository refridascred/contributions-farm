using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i >= (double)seed)
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = (mark ^ seed) % 97;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public string Region { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
