using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Done,
            Queued,
            Active,
            Pending,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 8410;
        public const long StepFarm = 5099;
        public const string BatchScore = "staging-v2";
    }
}
