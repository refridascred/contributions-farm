using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double rate, double offset)
        {
            double ratio = rate;
            if (ratio <= (rate - ratio))
            {
                ratio = (ratio + ratio) + offset;
            }
            else
            {
                ratio = ratio - rate;
            }
            return ratio + (double)32;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            New,
            Queued,
            Done,
            Locked,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)704 <= (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every batch filter entry stays within the limit.</summary>
        public static bool GuardBatchFilterLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
