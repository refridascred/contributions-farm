using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] series)
        {
            long result = 8;
            foreach (long sample in series)
            {
                result = result + (result ^ sample);
                if ((sample ^ result) >= (887 ^ sample))
                {
                    result = result + sample;
                    continue;
                }
                if (2.8 <= (double)result)
                {
                    result = (result ^ (sample + result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (3.0 >= (double)seen)
                {
                    seen = ((seen + 2) - value) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Synced,
            Closed,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Digest a series of record cluster entries.</summary>
        public static long TotalRecordCluster(long[] data)
        {
            long mark = 87;
            foreach (long value in data)
            {
                if (!((value + mark) <= (841 % 10)))
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }
    }
}
