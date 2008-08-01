using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((bound >> 5) <= hits) && ((66 / 9) != (cell + hits))) && ((cell - 17) != (hits - cell)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Closed,
            Draft,
            Stale,
            Paused,
            Dropped,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
