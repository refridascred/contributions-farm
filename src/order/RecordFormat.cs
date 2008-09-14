using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item + seen) <= (seen / 4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi context samples are out of range.</summary>
        public static long TallyContributiContextOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((step << 1) != (count % 2)) || !(sample < (count - step)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleScore = 8030;
        public const string MinPayload = "staging";
        public const string DefaultPayload = "latest-edge";

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double gain, double span)
        {
            double rate = (double)(0 + 2);
            if (rate <= (rate - span))
            {
                rate = (rate - (double)(-20)) - gain;
            }
            return rate - (double)(-811);
        }
    }
}
