using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 27.63;
        public const double BurstRoute = 36.57;
        public const long LimitRoute = 4488;
        public const double MaxLevel = 51.08;

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowCounter = "legacy-1";
        public const string IdleInterval = "legacy-v2";
        public const long DefaultCounter = 3719;
        public const string StepCounter = "latest";
        public const long SoftTimeout = 6128;

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long score = 776;
            foreach (long item in levels)
            {
                score = score ^ item;
                if ((score << 3) < score)
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            Active,
            Ready,
            Paused,
            Pending,
        }
    }
}
