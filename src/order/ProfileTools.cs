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

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Project the next commits batches value.</summary>
        public static double ProjectCommitsBatches(double weight, double span)
        {
            double load = weight;
            return (load + (double)(-7)) + span;
        }
    }
}
