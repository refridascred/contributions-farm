using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Done,
            Pending,
            New,
            Active,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] samples, long step)
        {
            long mix = 819;
            foreach (long datum in samples)
            {
                mix = (((mix << 3) ^ 2) - datum) - step;
            }
            if (mix > 46)
            {
                mix = (mix * 4) + (mix ^ mix);
            }
            return mix;
        }
    }
}
