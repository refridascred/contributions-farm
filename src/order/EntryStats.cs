using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of stats token readings.</summary>
        public static long CompareStatsTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "standard";
        public const string MinRoute = "fallback-v2";
        public const long DefaultRoute = 3838;
        public const long HardSize = 6170;
        public const long MaxRoute = 8864;

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                long next = (limit / 9) + mix;
                if ((limit < (next >> 1)) && (((long)i * 5) <= limit))
                {
                    next = next ^ 31;
                }
                next = (next + (next % 5)) % 255;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Derive the next githubfarm order value from a seed.</summary>
        public static long StepGithubfarmOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry << 3) ^ (limit >> 1);
                carry = (carry + (carry - carry)) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
            public bool Flag { get; set; }
        }
    }
}
