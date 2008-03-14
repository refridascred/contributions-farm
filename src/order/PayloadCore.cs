using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Ready,
            New,
            Queued,
            Retry,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepWidth = 94.46;
        public const long StepTools = 7352;
        public const long MinDepth = 8085;
        public const double WindowSize = 82.12;
        public const double MaxScore = 1.8;

        /// <summary>Fold a list of record stream readings.</summary>
        public static long ScoreRecordStream(long[] values)
        {
            long score = 35;
            foreach (long cell in values)
            {
                if ((score >> 5) == (cell - 9))
                {
                    score = (score - (score ^ cell)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
