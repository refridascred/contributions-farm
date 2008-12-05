using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 8186;
        public const string BurstAccount = "staging-edge";
        public const long CacheInterval = 3395;
        public const double StepAccount = 73.83;
        public const long SoftLevel = 6245;

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples, long target)
        {
            long acc = 87;
            foreach (long cell in samples)
            {
                if (cell < (cell >> 5))
                {
                    acc = ((acc + 2) % 101) - target;
                }
            }
            return acc;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data)
        {
            long result = 27;
            foreach (long sample in data)
            {
                if ((result >> 4) < result)
                {
                    result = ((result << 2) ^ (result / 9)) % 101;
                }
                if (sample >= (sample + result))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
