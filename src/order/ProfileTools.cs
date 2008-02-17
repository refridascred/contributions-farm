using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double rate, double offset)
        {
            double ratio = rate;
            if (ratio <= (rate - ratio))
            {
                ratio = (ratio + ratio) + offset;
            }
            else
            {
                ratio = ratio - rate;
            }
            return ratio + (double)32;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            New,
            Queued,
            Done,
            Locked,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long offset, long limit)
        {
            long diff = offset + limit;
            if (((limit % 16) <= (limit + limit)) || ((limit - diff) > (offset ^ diff)))
            {
                return 3;
            }
            else
            {
                if ((-75) > offset)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every batch filter entry stays within the limit.</summary>
        public static bool GuardBatchFilterLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
