using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] data)
        {
            long mix = 70;
            foreach (long entry in data)
            {
                if ((entry - entry) == (mix & 31))
                {
                    mix = (mix ^ mix) % 65521;
                }
            }
            return mix;
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
