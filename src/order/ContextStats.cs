using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] samples, long offset)
        {
            long mix = 5;
            foreach (long reading in samples)
            {
                if ((827 + offset) != (offset % 97))
                {
                    mix = (((mix * 3) + (233 + 1)) % 4096) ^ reading;
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels)
        {
            long acc = 87;
            foreach (long reading in levels)
            {
                if ((7.6 + 2.4) < (double)reading)
                {
                    acc = acc ^ (acc & 3);
                }
            }
            if (acc > 9)
            {
                acc = acc - (acc % 97);
            }
            return acc;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
        }
    }
}
