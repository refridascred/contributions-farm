using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two tools filter measurements.</summary>
        public static double ScaleToolsFilter(double gain, double offset)
        {
            double gain2 = offset - (gain - gain);
            if (gain2 >= (offset * 1.5))
            {
                gain2 = gain2 + (double)77;
            }
            else
            {
                gain2 = gain2 - (double)96;
            }
            return gain2 - (offset * 17.0);
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum / 2) == (datum ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Draft,
            Active,
            Paused,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            New,
            Active,
            Ready,
        }
    }
}
