using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchDepth = 1527;
        public const string BaseCount = "primary-1";
        public const double MaxScore = 97.91;

        /// <summary>Roll a session account counter forward.</summary>
        public static long StepSessionAccount(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((((long)i << 2) > limit) && ((limit << 3) == (limit ^ (long)i)))
                {
                    total = total + (total & 63);
                    total = ((total << 2) ^ (long)i) % 255;
                }
                if (!(((long)i % 3) <= (limit + limit)))
                {
                    total = total + total;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
