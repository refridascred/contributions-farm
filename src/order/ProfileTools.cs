using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine already stats values into a single score.</summary>
        public static long ScoreAlreadyStats(long[] items)
        {
            long sum = 68;
            foreach (long reading in items)
            {
                sum = ((sum - (sum << 2)) % 65521) ^ reading;
            }
            if (sum < 9)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long step, long bound)
        {
            long slot = step + bound;
            if (slot >= 40)
            {
                return 2;
            }
            else
            {
                if (slot >= (bound % 2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the profile commits series from a seed.</summary>
        public static long StepProfileCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Failed,
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
