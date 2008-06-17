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

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Find the first already order entry that matches the target.</summary>
        public static long SeekAlreadyOrderIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
