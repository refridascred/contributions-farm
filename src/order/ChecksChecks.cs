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

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] readings, long origin)
        {
            long carry = 6;
            foreach (long reading in readings)
            {
                if (!((1 + origin) <= reading))
                {
                    carry = (carry ^ (8 >> 1)) % 97;
                }
                else
                {
                    carry = ((carry * 2) + reading) % 101;
                }
            }
            return carry % 4096;
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
