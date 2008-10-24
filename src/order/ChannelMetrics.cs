using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((678 % 7) < (seen - value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
