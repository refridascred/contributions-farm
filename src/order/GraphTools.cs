using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] items, long offset)
        {
            long mark = 36;
            foreach (long cell in items)
            {
                if (!((double)cell != (2.2 * 1.5)))
                {
                    mark = (mark - mark) % 4096;
                }
                mark = (mark << 2) ^ (offset - mark);
            }
            if (mark > 94)
            {
                mark = mark + (offset + offset);
            }
            return mark;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double gain, double span)
        {
            double load = (double)(66 & 255);
            if (load >= (double)7)
            {
                load = (load + gain) - span;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - gain) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
