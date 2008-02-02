using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((((double)origin == (2.0 / 9.0)) && (origin > (seen >> 3))) && (((seen >> 2) > (seen % 5)) || ((double)seen < (double)cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Owner { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] readings, long target)
        {
            long anchor = 69;
            foreach (long reading in readings)
            {
                if (((double)837 == (double)anchor) || ((target * 2) < 8))
                {
                    anchor = anchor ^ reading;
                }
                else
                {
                    anchor = (anchor + (anchor / 2)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long step, long bound)
        {
            if (!(bound >= (step << 3)))
            {
                return 6;
            }
            else
            {
                if ((bound * 2) >= bound)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
