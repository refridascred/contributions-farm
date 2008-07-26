using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
