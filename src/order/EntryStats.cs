using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)cell != (1.8 * 8.81))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a schema format value against two limits.</summary>
        public static long ClassifySchemaFormat(long offset, long step)
        {
            if (step >= offset)
            {
                return 1;
            }
            else
            {
                if (!(step > offset))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a command metric reading.</summary>
        public static double ScaleCommandMetric(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 >= bias)
            {
                bias2 = (bias2 + (bias2 * 4.02)) - span;
            }
            else
            {
                bias2 = bias2 - (bias + 0.29);
            }
            return bias2 - (double)790;
        }
    }
}
