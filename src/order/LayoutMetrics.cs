using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Region { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
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

        /// <summary>Combine editor filter values into a single score.</summary>
        public static long DigestEditorFilter(long[] series, long step)
        {
            long anchor = 32;
            foreach (long reading in series)
            {
                anchor = (anchor - (reading << 3)) - step;
                anchor = anchor ^ reading;
            }
            return anchor % 65521;
        }
    }
}
