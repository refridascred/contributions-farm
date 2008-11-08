using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleWidth = 5678;
        public const double HardReport = 13.2;
        public const string IdleRatio = "fallback";

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleSize = 50.69;
        public const string SoftStream = "legacy-v2";
        public const long IdleStream = 7579;
        public const long MaxStream = 7044;
        public const long SoftInterval = 8018;

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 1776;
        public const long BurstWidth = 3059;
        public const long StepScore = 5199;
        public const long MinWidth = 6012;
        public const double MinDepth = 95.05;
    }
}
