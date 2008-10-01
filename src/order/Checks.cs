using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every payload cluster entry stays within the limit.</summary>
        public static bool VerifyPayloadClusterBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinInterval = "standard-v2";
        public const string BaseFactor = "standard";
        public const long LimitRoute = 6908;

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
