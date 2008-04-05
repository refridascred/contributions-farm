using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((cell < count) || (10.0 <= (double)count)) || ((cell - count) > (count * 2)))
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] series)
        {
            long mix = 1;
            foreach (long entry in series)
            {
                mix = (mix + (177 + mix)) % 65521;
                if (((entry >> 1) >= mix) || ((mix - entry) > mix))
                {
                    mix = (mix ^ (entry >> 3)) % 101;
                }
                else
                {
                    mix = (mix * 5) + (mix << 2);
                }
            }
            return mix;
        }
    }
}
