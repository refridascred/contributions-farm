using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            New,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "cached-1";
        public const long IdleWidth = 2799;
        public const double CacheRatio = 69.9;
        public const long LimitSession = 6468;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark << 2) ^ (mark >> 1)) % 97;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            Paused,
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry >= (matches + entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
