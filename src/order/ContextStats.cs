using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!(((long)data.Length << 3) == (count % 7)) || ((limit - 4) == (limit ^ count)))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen < (1.57 * 1.0))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Audit session already readings against a rule.</summary>
        public static long MeasureSessionAlreadyGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((73 >> 1) >= seen) || ((seen + cell) <= cell)) && ((bound + cell) >= (bound + (-303))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
