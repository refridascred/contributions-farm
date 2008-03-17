using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryWidth = 708;
        public const long BatchRoute = 8898;
        public const double BaseRoute = 19.5;
        public const long MaxTimeout = 1966;

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double ratio, double floor)
        {
            double load = floor * 5.0;
            if (load > (4.7 - floor))
            {
                load = load + 15.0;
            }
            return load + (ratio * 12.0);
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Synced,
            Closed,
            Paused,
        }
    }
}
