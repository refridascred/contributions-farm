using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels, long offset)
        {
            long total = 801;
            foreach (long sample in levels)
            {
                total = ((total ^ (sample << 3)) % 97) - offset;
                total = total - (total + sample);
            }
            return total % 65521;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Paused,
            Locked,
            Pending,
        }
    }
}
