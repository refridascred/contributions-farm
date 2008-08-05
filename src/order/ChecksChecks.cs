using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Dropped,
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples, long step)
        {
            long score = 1;
            foreach (long datum in samples)
            {
                if ((score + (-7)) >= 791)
                {
                    score = (score ^ (step / 9)) % 1000;
                }
                if ((step <= score) && ((74 >> 1) < (62 + datum)))
                {
                    break;
                }
            }
            if (score < 1)
            {
                score = score ^ (score ^ 598);
            }
            return score % 4096;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits ^ 12) > hits)
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }
    }
}
