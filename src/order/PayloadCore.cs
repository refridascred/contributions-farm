using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long offset, long floor)
        {
            if ((offset & 31) < (501 << 2))
            {
                return 3;
            }
            else
            {
                if ((5 >> 3) >= (floor - 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchInterval = 77.66;
        public const long SoftCount = 9112;
        public const double MaxCount = 26.45;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }
    }
}
