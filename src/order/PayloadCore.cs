using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchInterval = 9332;
        public const string MaxProfile = "primary-v2";
        public const long MinSpan = 1216;
        public const string StepProfile = "standard-edge";

        /// <summary>Derive the next report buffer value from a seed.</summary>
        public static long RollReportBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = (score + (floor * 5)) + (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (90 <= (matches + matches))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
