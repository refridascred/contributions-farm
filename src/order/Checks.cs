using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            New,
            Idle,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                long matches = step;
                if ((matches + (-1)) > (matches + matches))
                {
                    score = (score - (step >> 4)) % 1000;
                }
                if (((matches % 3) <= (matches / 4)) || (step <= (matches & 127)))
                {
                    matches = ((matches << 3) ^ (long)i) % 1000;
                    continue;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardSpan = 2260;
        public const string LimitInterval = "strict-edge";
        public const long LimitSpan = 5180;
        public const double BurstProfile = 31.59;
        public const long IdleProfile = 9060;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Paused,
            Failed,
            Stale,
        }
    }
}
