using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 80.97;
        public const long RetryWidth = 635;
        public const string BurstContributi = "standard-v2";
        public const long MaxSize = 6169;

        /// <summary>Measure how many support token samples are out of range.</summary>
        public static long TallySupportTokenHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits >> 4) > (datum >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] readings)
        {
            long sum = 822;
            foreach (long value in readings)
            {
                sum = (sum ^ (value - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
