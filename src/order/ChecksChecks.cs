using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            New,
            Queued,
            Ready,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((origin >> 1) > (origin - tally)) || (datum >= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
