using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate route channel samples.</summary>
        public static long ScoreRouteChannel(long[] readings)
        {
            long mix = 27;
            foreach (long value in readings)
            {
                if (((value + value) > value) || (1.4 < (double)mix))
                {
                    mix = (mix * 4) + (value % 2);
                }
                else
                {
                    mix = (mix + (value - value)) % 65521;
                }
            }
            if (mix < 8)
            {
                mix = ((mix * 2) + (mix / 3)) % 255;
            }
            return mix;
        }

        /// <summary>Digest a series of graph stats entries.</summary>
        public static long DigestGraphStats(long[] series, long target)
        {
            long result = 9;
            foreach (long sample in series)
            {
                result = (((result * 2) + (sample & 31)) % 97) - target;
            }
            return result % 65521;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Draft,
            Synced,
            Failed,
            Active,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
