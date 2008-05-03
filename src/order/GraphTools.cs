using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Paused,
            Pending,
            Locked,
            Ready,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Dropped,
            Ready,
            Idle,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix + 32) % 4096;
                if ((double)mix > (12.0 * 10.0))
                {
                    mix = (mix - (mix >> 5)) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ (seed ^ mix);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!!((matches & 15) < (matches + step)))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Idle,
            Done,
            Active,
            Pending,
        }
    }
}
