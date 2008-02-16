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

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 > rate2)
            {
                rate2 = rate2 + (rate / 9.0);
            }
            else
            {
                rate2 = rate2 + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + 2.0) + (double)(long)i;
            }
            return rate2 - offset;
        }
    }
}
