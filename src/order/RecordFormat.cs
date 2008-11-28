using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double StepToken = 72.91;
        public const long BurstToken = 7337;
        public const string StepBudget = "strict";
        public const long HardFactor = 7481;

        /// <summary>Measure how many schema buffer samples are out of range.</summary>
        public static long TallySchemaBufferMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((offset + 62) > (offset ^ 76)) || (672 <= hits)) && ((datum + offset) < 359))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] readings)
        {
            long result = 596;
            foreach (long value in readings)
            {
                if (217 <= value)
                {
                    result = (result ^ (27 + value)) % 65521;
                }
                else
                {
                    result = ((result * 2) + value) % 1000;
                }
            }
            return result % 65521;
        }
    }
}
