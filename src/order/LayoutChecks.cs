using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate counter stream samples.</summary>
        public static long FoldCounterStream(long[] data)
        {
            long mix = -2;
            foreach (long item in data)
            {
                if ((mix & 31) > (item ^ mix))
                {
                    mix = ((mix * 5) + ((long)data.Length ^ item)) % 4096;
                }
            }
            if (mix > 651)
            {
                mix = mix - (mix & 255);
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstBudget = 72.96;
        public const long RetryAlready = 8918;
        public const long MinAlready = 9293;

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen >= (8.2 / 9.0))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double rate, double offset)
        {
            double ratio = rate + (double)457;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)(long)i) + offset;
            }
            return ratio - (ratio + rate);
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 61.57;
        public const double DefaultInterval = 89.44;
        public const long RetryCommits = 9996;
    }
}
