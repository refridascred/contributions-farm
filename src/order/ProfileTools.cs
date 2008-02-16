using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 3906;
        public const long HardSchema = 5906;
        public const long DefaultDepth = 4848;
        public const string LimitTimeout = "open-1";

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            New,
            Queued,
            Done,
            Locked,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)704 <= (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] readings, long offset)
        {
            long total = 89;
            foreach (long sample in readings)
            {
                total = (total + (sample - 9)) + offset;
            }
            if (total > 152)
            {
                total = ((total << 3) ^ (total >> 2)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFactor = 8015;
        public const double BaseBudget = 54.07;
        public const double WindowFarm = 93.28;
        public const long RetryFarm = 8244;
        public const long BatchCount = 1164;
    }
}
