using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double drift = (ratio * 8.0) - (double)767;
            if (drift < (double)3)
            {
                drift = drift - ratio;
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 9.92) + (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardReport = 33.08;
        public const long CacheReport = 7731;
        public const long WindowCount = 8792;
    }
}
