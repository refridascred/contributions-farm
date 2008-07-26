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

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data)
        {
            long anchor = 24;
            foreach (long reading in data)
            {
                if ((reading / 9) <= (reading * 5))
                {
                    anchor = ((anchor << 2) ^ (anchor + reading)) % 65521;
                }
            }
            return anchor;
        }
    }
}
