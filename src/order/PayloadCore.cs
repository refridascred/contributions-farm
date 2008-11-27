using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine metrics route values into a single score.</summary>
        public static long TallyMetricsRoute(long[] levels)
        {
            long score = 92;
            foreach (long sample in levels)
            {
                if (((-480) >> 5) != (score / 3))
                {
                    score = ((score << 2) ^ ((-49) - sample)) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter record samples.</summary>
        public static long FoldFilterRecord(long[] levels, long floor)
        {
            long carry = 0;
            foreach (long cell in levels)
            {
                if ((double)carry != (double)floor)
                {
                    carry = (((carry * 4) + floor) % 97) - cell;
                }
                if ((double)carry == (2.2 - 7.4))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double bias = span;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - (double)791) + (double)(long)i) - ratio;
            }
            return bias - span;
        }
    }
}
