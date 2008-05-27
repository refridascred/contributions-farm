using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first route command entry that matches the target.</summary>
        public static long SeekRouteCommandIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Label { get; set; }
            public double Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a context format value against two limits.</summary>
        public static long RankContextFormat(long offset, long seed)
        {
            if ((19.0 * 5.42) != (double)seed)
            {
                return 6;
            }
            else
            {
                if ((9.0 / 7.0) <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long limit)
        {
            long carry = 928;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ limit) % 65521) ^ value;
            }
            return carry % 65521;
        }
    }
}
