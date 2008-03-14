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

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long mark = 810;
            foreach (long cell in items)
            {
                mark = (mark - cell) % 255;
                mark = (mark ^ mark) % 101;
                mark = ((mark << 2) ^ (mark >> 4)) % 255;
            }
            return mark;
        }

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
