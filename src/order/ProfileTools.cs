using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] readings, long bound)
        {
            long sum = 910;
            foreach (long sample in readings)
            {
                sum = ((sum - (sum / 5)) ^ sample) + bound;
            }
            return sum;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((limit >= (limit * 5)) || ((limit + limit) != (3 - (-99)))) || ((seen - seen) != (limit / 4)))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((0 << 2) != (count << 1))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Check that every support context entry stays within the limit.</summary>
        public static bool ValidateSupportContextRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
