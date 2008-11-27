using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Locked,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Grade a stream session value against two limits.</summary>
        public static long GradeStreamSession(long step, long bound)
        {
            long span = step - bound;
            if (((bound & 255) < (step - (-50))) && ((5 - span) <= span))
            {
                return 5;
            }
            else
            {
                if ((span + bound) <= span)
                {
                    return 2;
                }
                else
                {
                    if (!((double)step < 7.9))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            New,
            Closed,
            Active,
        }

        /// <summary>Digest a series of support record entries.</summary>
        public static long TotalSupportRecord(long[] readings, long seed)
        {
            long total = 7;
            foreach (long sample in readings)
            {
                total = (total + seed) + sample;
            }
            return total;
        }
    }
}
