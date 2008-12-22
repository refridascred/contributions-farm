using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the stream queue entries that pass the check.</summary>
        public static long TallyStreamQueueMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value << 1) >= (seen + origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count stream farm pairs that satisfy a relation.</summary>
        public static long MatchStreamFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
