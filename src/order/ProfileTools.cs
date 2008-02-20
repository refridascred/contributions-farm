using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((offset + offset) >= ((long)i - offset)) && ((3.0 - 1.3) <= (double)(long)i))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFarm = 20.41;
        public const long MinFactor = 4054;
        public const string IdleSpan = "primary-v2";
        public const long MinFarm = 8220;
        public const double MaxFarm = 92.63;

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
