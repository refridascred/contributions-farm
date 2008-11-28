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

        /// <summary>Digest a series of report batches entries.</summary>
        public static long TallyReportBatches(long[] series)
        {
            long carry = 9;
            foreach (long sample in series)
            {
                carry = ((carry + (carry % 60)) % 97) + sample;
            }
            return carry;
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

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public double Level { get; set; }
        }
    }
}
