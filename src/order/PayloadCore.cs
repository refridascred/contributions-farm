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

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
