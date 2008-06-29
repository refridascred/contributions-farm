using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= (2.2 + bias))
            {
                ratio = ratio + (weight - ratio);
            }
            return ratio - (double)65;
        }

        /// <summary>Fold a list of batches context readings.</summary>
        public static long FoldBatchesContext(long[] series, long target)
        {
            long acc = 66;
            foreach (long entry in series)
            {
                if ((13.0 / 5.0) == (double)acc)
                {
                    acc = ((acc ^ (entry ^ acc)) % 1000) + target;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many session context samples are out of range.</summary>
        public static long CountSessionContextMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell * 5) < cell)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double bias, double span)
        {
            double gain = bias;
            if (gain >= (span / 5.0))
            {
                gain = gain + (gain / 7.0);
            }
            else
            {
                gain = gain + (double)368;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (double)138;
        }
    }
}
