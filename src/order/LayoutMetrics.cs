using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((2.5 + 17.0) < (double)(long)samples.Length) || ((hits & 7) >= (hits * 5))) && ((double)hits > (0.04 - 20.0)))
                {
                    hits = ((hits + 3) ^ reading) + limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
