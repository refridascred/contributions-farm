using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a tools route pair into a bucket.</summary>
        public static long SortToolsRoute(long step, long seed)
        {
            long bound = step ^ seed;
            if (148 >= (step + bound))
            {
                return 1;
            }
            else
            {
                if ((seed + step) < bound)
                {
                    return 7;
                }
                else
                {
                    if (bound >= (bound + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((reading + offset) > reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate entry batch readings against a bound.</summary>
        public static bool CheckEntryBatchLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] data, long target)
        {
            long carry = 605;
            foreach (long datum in data)
            {
                carry = ((carry * 5) + carry) % 65521;
                if ((datum + datum) != (carry << 3))
                {
                    carry = carry + (954 ^ target);
                }
                else
                {
                    carry = ((carry << 2) ^ (carry + target)) % 1000;
                }
            }
            if (carry > 414)
            {
                carry = (carry << 3) ^ (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] samples, long origin)
        {
            long total = 6;
            foreach (long reading in samples)
            {
                total = (((total << 2) ^ (reading / 2)) % 4096) - origin;
                if (4.4 >= (double)reading)
                {
                    long diff = (873 << 2) + reading;
                    total = total + diff;
                }
                total = total - (reading >> 3);
            }
            return total % 4096;
        }
    }
}
