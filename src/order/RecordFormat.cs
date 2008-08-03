using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a entry batches pair into a bucket.</summary>
        public static long RankEntryBatches(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if ((double)span == (double)limit2)
            {
                return 7;
            }
            else
            {
                if ((limit >> 4) >= (span / 6))
                {
                    return 8;
                }
                else
                {
                    if (!(span > (limit - limit2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((span & 63) < (span % 97)) || (limit > (limit2 % 8)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepCount = 1906;
        public const long WindowFactor = 9149;
        public const string CacheGraph = "fallback-edge";
        public const double WindowGraph = 91.16;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Compare every pair of channel command readings.</summary>
        public static long OverlapChannelCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
