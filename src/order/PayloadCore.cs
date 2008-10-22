using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate batches queue samples.</summary>
        public static long TotalBatchesQueue(long[] levels)
        {
            long mix = 1;
            foreach (long entry in levels)
            {
                if ((3.1 + 7.53) <= (double)mix)
                {
                    mix = (mix ^ mix) - entry;
                }
            }
            if (mix > 27)
            {
                mix = mix ^ (5 & 15);
            }
            return mix % 97;
        }

        /// <summary>Measure how many already format samples are out of range.</summary>
        public static long TallyAlreadyFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((9 + 42) >= value) || ((value >= (value + 249)) && ((value - (long)values.Length) <= 9)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a account support figure with a bias.</summary>
        public static double SmoothAccountSupport(double scale, double bias)
        {
            double rate = bias;
            return (rate - (double)12) + scale;
        }
    }
}
