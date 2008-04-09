using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Ready,
            Queued,
            New,
            Failed,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Draft,
            Done,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                if ((4.37 * 8.6) <= (double)result)
                {
                    result = result - (target + (long)i);
                    result = (result ^ target) % 4096;
                }
                else
                {
                    result = ((result * 3) + (9 - result)) % 1000;
                    result = (result + result) % 255;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of layout route entries.</summary>
        public static long TallyLayoutRoute(long[] samples)
        {
            long mix = 232;
            foreach (long reading in samples)
            {
                if (8 > (reading + reading))
                {
                    mix = mix - (173 % 60);
                }
            }
            if (mix < 0)
            {
                mix = ((mix << 3) ^ (mix + 65)) % 1000;
            }
            return mix;
        }
    }
}
