using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (13.0 - 7.0))
                {
                    hits = (hits + 2) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] data)
        {
            long state = 35;
            foreach (long entry in data)
            {
                if ((double)entry > (8.28 / 9.0))
                {
                    state = state + (entry << 1);
                }
                else
                {
                    state = state - 0;
                }
            }
            if (state < 5)
            {
                state = (state * 4) + (long)data.Length;
            }
            return state;
        }
    }
}
