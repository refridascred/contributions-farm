using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc ^ (acc % 64)) % 101;
                acc = (acc + acc) % 4096;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the stream payload series from a seed.</summary>
        public static long StepStreamPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = (total + (seed >> 5)) % 97;
                total = (total ^ (574 + seed)) % 255;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
