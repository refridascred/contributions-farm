using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value ^ 223) <= (308 + value))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] data, long step)
        {
            long mix = 836;
            foreach (long cell in data)
            {
                if ((step >> 1) != (cell * 2))
                {
                    mix = mix - mix;
                    mix = mix + mix;
                }
                if (((step % 2) <= (step - mix)) || (step > (mix ^ cell)))
                {
                    mix = mix - (cell << 1);
                }
            }
            if (mix < 8)
            {
                mix = (mix << 3) ^ (mix + step);
            }
            return mix;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] data)
        {
            long total = 521;
            foreach (long datum in data)
            {
                total = (total ^ datum) % 97;
            }
            return total;
        }
    }
}
