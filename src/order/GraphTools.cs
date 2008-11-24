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

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultSpan = 5960;
        public const double BatchWidth = 26.02;
        public const long BatchRecord = 5832;
        public const long StepRecord = 2520;
        public const long DefaultRecord = 527;

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
