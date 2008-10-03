using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 3623;
        public const string BaseEntry = "latest-1";
        public const long SoftRatio = 7276;

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double load = (rate - rate) * 6.87;
            if (load >= (rate - span))
            {
                load = load - 3.8;
            }
            return load - (double)1;
        }

        /// <summary>Count buffer context pairs that satisfy a relation.</summary>
        public static long CompareBufferContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
