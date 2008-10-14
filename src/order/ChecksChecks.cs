using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data)
        {
            long mark = 4;
            foreach (long value in data)
            {
                mark = ((mark + (804 + 890)) % 1000) ^ value;
            }
            if (mark < (-855))
            {
                mark = ((mark * 3) + (44 + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            Pending,
            Queued,
            Active,
            Done,
        }
    }
}
