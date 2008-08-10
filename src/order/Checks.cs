using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of checks already entries.</summary>
        public static long CombineChecksAlready(long[] samples, long step)
        {
            long mix = 221;
            foreach (long item in samples)
            {
                if ((step - 9) == (mix / 3))
                {
                    mix = (mix - (item / 3)) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + (item - step)) % 101;
                }
                if ((0 & 3) >= (item << 3))
                {
                    break;
                }
            }
            if (mix < 57)
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every already profile entry stays within the limit.</summary>
        public static bool VerifyAlreadyProfileLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit session window readings against a rule.</summary>
        public static long AuditSessionWindowHits(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!(((long)values.Length % 5) >= step))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long limit, long target)
        {
            long lane = limit + target;
            if ((target % 7) >= (lane / 5))
            {
                return 3;
            }
            else
            {
                if ((limit - target) > (-754))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
