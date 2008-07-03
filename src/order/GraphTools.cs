using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the farm window entries that pass the check.</summary>
        public static long AuditFarmWindowMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen == (3.5 * 1.3))
                {
                    seen = ((seen + 1) ^ item) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double scale, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - weight) - (double)(long)i) - scale;
            }
            return weight - (weight / 7.0);
        }
    }
}
