using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate counter stats samples.</summary>
        public static long DigestCounterStats(long[] items, long step)
        {
            long total = 2;
            foreach (long item in items)
            {
                total = (total * 3) + (step + step);
                if ((item + step) > step)
                {
                    total = (total + 567) % 97;
                }
                if (((total - 467) != (total - (-908))) && (total <= (item + item)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double floor)
        {
            double load = (5.7 / 3.0) + (double)(-16);
            if (load >= floor)
            {
                load = (load + (load * 1.1)) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + 9.31) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches + 325) <= (matches + matches))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }
    }
}
