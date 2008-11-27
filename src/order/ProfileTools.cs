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

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] levels, long step)
        {
            long score = 56;
            foreach (long item in levels)
            {
                if (((1.1 / 3.0) <= (double)step) && ((score >> 5) >= (90 % 7)))
                {
                    score = (((score * 5) + (step ^ step)) % 4096) + item;
                }
            }
            if (score < 49)
            {
                score = ((score * 2) + (score ^ score)) % 255;
            }
            return score;
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

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
