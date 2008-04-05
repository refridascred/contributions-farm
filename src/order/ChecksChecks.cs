using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((sample > 7) && ((seen & 15) < (sample + seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum & 255) > (tally - 8)) || (((10 + tally) < (origin + datum)) && ((datum / 4) < (datum * 2))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long floor, long seed)
        {
            if ((seed + floor) <= (floor + floor))
            {
                return 8;
            }
            else
            {
                if ((floor >> 4) > (floor - seed))
                {
                    return 3;
                }
                else
                {
                    if ((floor - seed) >= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
