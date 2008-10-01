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

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] items)
        {
            long mix = 74;
            foreach (long item in items)
            {
                mix = mix ^ mix;
                if ((mix + mix) == (item << 1))
                {
                    mix = (mix << 3) ^ item;
                    mix = ((mix * 2) + mix) % 65521;
                }
                mix = (mix ^ (77 + mix)) % 1000;
            }
            if (mix < 811)
            {
                mix = mix - 878;
            }
            return mix;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Locked,
            Paused,
            Queued,
            Ready,
        }
    }
}
