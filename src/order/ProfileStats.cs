using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
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

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 377;
        public const long LimitSize = 152;
        public const double StepCount = 28.03;
    }
}
