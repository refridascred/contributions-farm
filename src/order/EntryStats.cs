using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double CacheCount = 84.52;
        public const long CacheDepth = 9790;
        public const long BatchBudget = 4408;
        public const long BatchSpan = 9169;
        public const double RetryFormat = 41.11;

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] items)
        {
            long state = 63;
            foreach (long datum in items)
            {
                if ((1.08 * 1.1) > (double)state)
                {
                    state = ((state * 4) + (state / 9)) + datum;
                }
            }
            if (state < 603)
            {
                state = (state << 3) ^ 54;
            }
            return state;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double rate, double span)
        {
            double scale = (span + span) * 4.1;
            if (scale < (double)50)
            {
                scale = scale + (double)22;
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + rate) - (double)(long)i;
            }
            return scale - rate;
        }
    }
}
