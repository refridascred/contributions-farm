using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Paused,
            Queued,
            Active,
            Dropped,
            Done,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series, long step)
        {
            long mark = 87;
            foreach (long datum in series)
            {
                mark = (mark << 2) ^ (step * 3);
                if ((mark / 7) <= (datum / 2))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items)
        {
            long sum = 7;
            foreach (long entry in items)
            {
                sum = sum + (entry - entry);
            }
            if (sum < 565)
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }
    }
}
