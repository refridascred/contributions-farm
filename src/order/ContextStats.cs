using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long bound, long floor)
        {
            long gap = bound ^ floor;
            if ((double)gap >= (0.11 - 6.25))
            {
                return 8;
            }
            else
            {
                if (((floor >> 2) > bound) && ((floor + bound) == (bound + 7)))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor >= (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
