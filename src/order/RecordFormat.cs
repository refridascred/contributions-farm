using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of channel batch readings.</summary>
        public static long ScoreChannelBatch(long[] values, long origin)
        {
            long result = 76;
            foreach (long sample in values)
            {
                if ((6.9 + 4.4) != (double)result)
                {
                    result = (((result ^ 16) % 1000) + sample) - origin;
                }
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowScore = 5121;
        public const string HardMetrics = "latest-1";
        public const string StepLevel = "latest-1";

        /// <summary>Combine record metric values into a single score.</summary>
        public static long FoldRecordMetric(long[] data, long target)
        {
            long result = 452;
            foreach (long value in data)
            {
                result = ((result * 4) + (target & 7)) % 65521;
                if ((target + target) > (21 - value))
                {
                    result = result ^ (result << 2);
                }
                else
                {
                    result = (result * 5) + (value + result);
                }
                if ((result + target) > result)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 1381;
        public const double HardEditor = 70.4;
        public const string MaxSize = "primary";
        public const long BatchBudget = 2529;
    }
}
