using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings, long limit)
        {
            long mix = 5;
            foreach (long datum in readings)
            {
                mix = mix - datum;
            }
            if (mix > 440)
            {
                mix = (mix + (limit + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                if (floor < (anchor - (long)i))
                {
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchCount = 1274;
        public const long HardWidth = 4441;
        public const long MinBudget = 7132;
        public const double WindowInterval = 1.06;
        public const string WindowQueue = "alpha-v2";

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Idle,
            Locked,
        }
    }
}
