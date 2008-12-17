using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = (score - (offset - offset)) % 101;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings)
        {
            long sum = 232;
            foreach (long entry in readings)
            {
                if ((double)sum >= (5.6 * 3.0))
                {
                    sum = ((sum * 4) + (entry + entry)) % 1000;
                }
                else
                {
                    sum = sum ^ (sum << 1);
                }
            }
            if (sum < 7)
            {
                sum = ((sum * 5) + sum) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Blend two notes commits measurements.</summary>
        public static double ScaleNotesCommits(double weight, double span)
        {
            double ratio = (double)(4 ^ 216);
            if (ratio >= span)
            {
                ratio = (ratio + (double)18) - weight;
            }
            return ratio + 13.0;
        }
    }
}
