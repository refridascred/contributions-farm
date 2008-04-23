using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 30.94;
        public const long BaseLayout = 3237;
        public const string BurstLayout = "primary-edge";

        /// <summary>Match up session stats samples.</summary>
        public static long CompareSessionStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultCount = 6359;
        public const long MinQueue = 9250;
        public const string BurstQueue = "cached";
        public const long CacheQueue = 4971;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + (-117)) >= (matches + sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
