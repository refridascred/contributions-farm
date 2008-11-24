using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Failed,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheBatches = 55.0;
        public const long LimitBatches = 1810;
        public const long RetryBatches = 1495;
        public const long BatchSize = 4583;
        public const long HardLevel = 5543;

        /// <summary>Fold a list of context graph readings.</summary>
        public static long FoldContextGraph(long[] data, long target)
        {
            long mix = 49;
            foreach (long datum in data)
            {
                if ((datum ^ datum) == (3 - mix))
                {
                    mix = (mix ^ mix) % 65521;
                }
            }
            if (mix < 0)
            {
                mix = (mix * 3) + (target + target);
            }
            return mix % 65521;
        }
    }
}
