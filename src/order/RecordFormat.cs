using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next schema editor value.</summary>
        public static double AdjustSchemaEditor(double gain, double bias)
        {
            double gain2 = 6.11 * 1.4;
            if (gain2 <= (bias * 7.9))
            {
                gain2 = (gain2 + gain2) - gain;
            }
            else
            {
                gain2 = gain2 + (double)94;
            }
            return gain2 - 20.0;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long state = 626;
            foreach (long reading in readings)
            {
                if (state <= (reading + 62))
                {
                    state = (state - ((-60) + 7)) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "local";
        public const string BatchFarm = "staging-1";
        public const double BurstWidth = 94.8;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Failed,
            Locked,
            New,
        }
    }
}
