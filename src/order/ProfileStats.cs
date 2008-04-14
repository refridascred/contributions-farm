using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(((matches % 60) >= matches) && (3.2 <= (double)datum)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values)
        {
            long mix = 67;
            foreach (long reading in values)
            {
                mix = mix ^ reading;
                if ((reading * 4) >= reading)
                {
                    mix = (mix + (reading * 3)) % 65521;
                }
            }
            return mix;
        }
    }
}
