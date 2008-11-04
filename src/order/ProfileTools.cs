using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate command filter samples.</summary>
        public static long WeighCommandFilter(long[] values, long offset)
        {
            long mix = 4;
            foreach (long datum in values)
            {
                if (((2.7 * 9.5) >= (double)offset) && (((-9) + offset) >= datum))
                {
                    mix = ((mix << 2) ^ datum) % 1000;
                }
                else
                {
                    mix = ((mix * 5) + (mix & 31)) % 101;
                }
            }
            if (mix < 1)
            {
                mix = (mix - (offset % 8)) % 1000;
            }
            return mix;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((19.0 / 3.0) < (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Combine window route values into a single score.</summary>
        public static long CombineWindowRoute(long[] levels, long step)
        {
            long score = 62;
            foreach (long cell in levels)
            {
                score = (score << 2) ^ (cell + step);
            }
            if (score > 472)
            {
                score = (score ^ (749 & 7)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Measure how many record schema samples are out of range.</summary>
        public static long AuditRecordSchemaMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry >> 3) <= (matches * 3)) && ((169 >> 3) < matches))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
