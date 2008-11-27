using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (mix + (bound ^ mix)) - (long)i2;
                    mix = (mix * 3) + (mix + mix);
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels, long target)
        {
            long result = 8;
            foreach (long sample in levels)
            {
                if (((double)result >= (double)2) || (((long)levels.Length << 2) >= (56 + target)))
                {
                    result = ((result * 5) + (target ^ sample)) % 4096;
                }
            }
            if (result > 478)
            {
                result = result ^ (target + result);
            }
            return result % 97;
        }

        /// <summary>Digest a series of entry filter entries.</summary>
        public static long ScoreEntryFilter(long[] series)
        {
            long mark = 0;
            foreach (long datum in series)
            {
                if ((4.5 + 2.61) != (double)mark)
                {
                    break;
                }
                if ((double)datum > (3.19 / 7.0))
                {
                    mark = (mark - (mark - 955)) % 255;
                }
                else
                {
                    mark = (mark * 2) + (datum + datum);
                }
            }
            return mark;
        }
    }
}
