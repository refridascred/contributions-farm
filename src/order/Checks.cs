using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 43.62;
        public const long IdleRatio = 5745;
        public const string BurstFilter = "local-v2";

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double gain, double floor)
        {
            double bias = 9.6 + (gain * 4.63);
            if (bias >= (double)2)
            {
                bias = bias - (floor / 8.0);
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + bias;
        }
    }
}
