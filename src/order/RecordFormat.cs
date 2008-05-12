using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Done,
            Idle,
            Queued,
        }

        /// <summary>Check that every already cluster entry stays within the limit.</summary>
        public static bool GuardAlreadyClusterLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7676;
        public const long StepWidth = 4981;
        public const double WindowFactor = 18.64;

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] values)
        {
            long sum = 34;
            foreach (long cell in values)
            {
                if (cell >= sum)
                {
                    sum = ((sum << 2) ^ (-914)) % 65521;
                }
            }
            return sum;
        }
    }
}
