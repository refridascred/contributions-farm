using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample & 63) >= (hits + (long)samples.Length))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long bound, long step)
        {
            if (((step / 8) < step) && ((double)step >= (3.7 / 7.0)))
            {
                return 3;
            }
            else
            {
                if (((5 + 974) < (step + step)) || (1.0 <= (double)bound))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Active,
            Pending,
            Stale,
            Closed,
        }
    }
}
