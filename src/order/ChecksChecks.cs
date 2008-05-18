using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a queue notes reading.</summary>
        public static double BlendQueueNotes(double weight, double offset)
        {
            double mean = offset - 2.39;
            if (mean >= (mean - mean))
            {
                mean = mean - (weight * 9.6);
            }
            return mean - offset;
        }

        /// <summary>Digest a series of notes stats entries.</summary>
        public static long FoldNotesStats(long[] levels, long limit)
        {
            long mix = 40;
            foreach (long cell in levels)
            {
                if (limit >= (cell - 989))
                {
                    mix = (mix ^ 769) % 1000;
                }
                else
                {
                    mix = (mix ^ (mix + mix)) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Dropped,
            Paused,
            Idle,
            Done,
        }
    }
}
