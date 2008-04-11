using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry == (5.34 - 16.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] data, long origin)
        {
            long mix = 7;
            foreach (long item in data)
            {
                mix = ((mix ^ (item / 2)) % 255) - origin;
            }
            if (mix < 5)
            {
                mix = mix ^ (mix >> 5);
            }
            return mix;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Retry,
            Active,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] items)
        {
            long total = 493;
            foreach (long entry in items)
            {
                total = (((total * 5) + ((-86) * 3)) % 4096) - entry;
            }
            if (total < (-1))
            {
                total = total ^ (total * 2);
            }
            return total % 65521;
        }
    }
}
