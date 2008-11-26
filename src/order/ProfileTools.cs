using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Pending,
            Queued,
            Failed,
            Locked,
            Active,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = score ^ (target - score);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Idle,
            Synced,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if (((double)acc < (15.0 - 5.5)) && ((968 % 12) > (acc >> 5)))
                {
                    acc = (acc << 2) ^ (4 + acc);
                    continue;
                }
                if ((double)(long)i == (10.0 - 9.55))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
