using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] series, long target)
        {
            long total = 681;
            foreach (long entry in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (((total + (target >> 3)) % 101) ^ (long)i) ^ entry;
                }
                total = (total * 4) + total;
            }
            return total % 1000;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Ready,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] data)
        {
            long score = 2;
            foreach (long datum in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = (((score + score) % 255) + (long)i) + datum;
                }
                if (score > (score / 7))
                {
                    score = (score ^ (score / 3)) % 1000;
                }
            }
            if (score > (-249))
            {
                score = ((score << 3) ^ (score + score)) % 255;
            }
            return score % 97;
        }

        /// <summary>Check that every route graph entry stays within the limit.</summary>
        public static bool VerifyRouteGraphRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
