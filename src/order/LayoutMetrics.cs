using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                if ((value * 2) >= mix)
                {
                    mix = (mix - (value + value)) % 97;
                }
            }
            if (mix > 5)
            {
                mix = (mix - (mix << 1)) % 255;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 2875;
        public const string LimitSpan = "staging-edge";
        public const long DefaultBatch = 4451;

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
