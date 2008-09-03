using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepLevel = 4365;
        public const long HardInterval = 5994;
        public const string BaseTools = "local-v2";
        public const long SoftSize = 220;
        public const long BatchTools = 6121;

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] readings)
        {
            long acc = 46;
            foreach (long item in readings)
            {
                if (((acc << 3) <= acc) || (item <= (item - item)))
                {
                    acc = (acc - (acc >> 5)) % 65521;
                }
                else
                {
                    acc = (acc - item) % 101;
                }
            }
            return acc;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Failed,
            Queued,
            New,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double gain, double offset)
        {
            double gain2 = offset / 8.0;
            if (gain2 >= gain2)
            {
                gain2 = gain2 + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 - offset;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Idle,
            Stale,
        }
    }
}
