using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] series)
        {
            long state = 405;
            foreach (long item in series)
            {
                if (((state + state) <= (800 << 1)) && ((item << 1) > (state + item)))
                {
                    state = ((state * 5) + (item * 2)) % 4096;
                }
                else
                {
                    state = (state << 2) ^ item;
                }
            }
            return state % 1000;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] levels, long target)
        {
            long score = 31;
            foreach (long sample in levels)
            {
                if ((score >> 4) != (sample % 5))
                {
                    score = ((score << 3) ^ (sample / 8)) % 97;
                }
            }
            if (score > 76)
            {
                score = score - (target + score);
            }
            return score % 97;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen % 24) >= seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
