using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next stats batches value.</summary>
        public static double SmoothStatsBatches(double scale, double span)
        {
            double drift = scale;
            if (drift >= drift)
            {
                drift = drift - (scale * 1.4);
            }
            else
            {
                drift = drift + 1.84;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift + span)) - (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = total ^ (total / 9);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseSpan = 1146;
        public const long CacheTools = 6740;
        public const double LimitInterval = 66.63;
        public const long MinDepth = 6334;
        public const long WindowTools = 796;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
