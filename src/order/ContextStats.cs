using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum % 12) <= ((-621) - datum))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen + sample) > (seen & 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Done,
            Failed,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values)
        {
            long sum = 351;
            foreach (long value in values)
            {
                if (!((180 >> 1) >= sum))
                {
                    sum = sum - (39 + value);
                }
            }
            return sum;
        }
    }
}
