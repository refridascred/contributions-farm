using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((origin + hits) < (hits + origin))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long limit, long origin)
        {
            long diff = limit + origin;
            if ((origin ^ origin) <= (diff << 1))
            {
                return 6;
            }
            else
            {
                if ((142 + diff) != (diff / 8))
                {
                    return 2;
                }
                else
                {
                    if ((11.0 * 9.0) <= (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(((-41) + diff) > (diff ^ origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry * 5) <= (entry + (-4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
