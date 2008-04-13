using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxTimeout = 2656;
        public const long HardScore = 4194;
        public const double MinOrder = 16.15;
        public const string SoftBudget = "staging-edge";
        public const string BatchTimeout = "legacy";

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((8 / 8) != (datum & 255)) || ((double)datum >= (6.3 - 8.0)))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 3) ^ mark) % 1000;
                if (((9 + offset) > mark) || ((3.8 / 4.0) != (double)(long)i))
                {
                    mark = ((mark << 2) ^ (offset ^ (long)i)) % 97;
                    mark = mark ^ (long)i;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
