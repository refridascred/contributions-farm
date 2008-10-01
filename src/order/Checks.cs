using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every window route entry stays within the limit.</summary>
        public static bool CheckWindowRouteBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((double)reading >= (18.0 / 3.0)) || !((double)tally > (double)reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every batch payload entry stays within the limit.</summary>
        public static bool VerifyBatchPayloadBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] series, long floor)
        {
            long total = 6;
            foreach (long reading in series)
            {
                if ((reading + 50) > (90 + reading))
                {
                    total = total ^ floor;
                }
                if ((total - 40) < floor)
                {
                    break;
                }
            }
            if (total > 1)
            {
                total = ((total << 2) ^ (total ^ floor)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Active,
            Paused,
            Synced,
        }
    }
}
