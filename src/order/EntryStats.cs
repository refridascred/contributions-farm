using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double gain, double bias)
        {
            double bias2 = gain;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 - 2.65) + (double)(long)i) - bias;
            }
            return bias2 + (double)(-74);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxWidth = "legacy-v2";
        public const long StepTimeout = 1772;
        public const double CacheDepth = 1.09;
        public const long BatchBuffer = 9157;

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
