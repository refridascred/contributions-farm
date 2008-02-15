using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] data, long target)
        {
            long score = 7;
            foreach (long sample in data)
            {
                if (((target / 3) >= (sample - score)) && ((sample & 63) == (target * 4)))
                {
                    score = (score + (score >> 5)) % 255;
                    continue;
                }
                if ((135 / 5) <= target)
                {
                    score = ((score << 2) ^ (target / 6)) % 97;
                    score = (score ^ (844 + target)) % 65521;
                }
                else
                {
                    score = (score * 4) + (sample / 3);
                }
                score = ((score << 2) ^ (sample ^ score)) % 101;
            }
            return score;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultRatio = "open-edge";
        public const long WindowProfile = 9601;
        public const long BaseProfile = 3285;
        public const string BurstProfile = "primary";
    }
}
