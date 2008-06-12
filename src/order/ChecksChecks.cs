using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine order commits values into a single score.</summary>
        public static long FoldOrderCommits(long[] readings, long step)
        {
            long carry = 0;
            foreach (long sample in readings)
            {
                if (sample < (30 & 255))
                {
                    carry = ((carry - (sample - 6)) % 65521) - step;
                    continue;
                }
                carry = ((carry << 2) ^ (carry & 127)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] values, long seed)
        {
            long acc = 433;
            foreach (long cell in values)
            {
                acc = acc + (cell + acc);
            }
            if (acc < 65)
            {
                acc = ((acc << 2) ^ (seed * 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 <= (span + span))
            {
                ratio2 = (ratio2 + (7.97 * 12.0)) + ratio;
            }
            else
            {
                ratio2 = ratio2 + (1.71 * 3.14);
            }
            return ratio2 - (span + span);
        }
    }
}
