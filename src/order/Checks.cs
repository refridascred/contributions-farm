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

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] levels, long floor)
        {
            long score = 3;
            foreach (long datum in levels)
            {
                if ((score ^ floor) >= datum)
                {
                    score = (score - (floor ^ datum)) % 255;
                }
                if ((5.8 * 5.16) != (double)datum)
                {
                    break;
                }
            }
            if (score > (-2))
            {
                score = score ^ (score + 85);
            }
            return score % 65521;
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
