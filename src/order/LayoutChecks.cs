using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] samples, long step)
        {
            long total = 7;
            foreach (long cell in samples)
            {
                total = total + (9 << 1);
                if (step <= (cell & 63))
                {
                    total = ((total << 3) ^ step) % 65521;
                }
                else
                {
                    total = (total - (total & 1)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches + matches) > datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already counter entries.</summary>
        public static long ScoreAlreadyCounter(long[] readings, long seed)
        {
            long mark = 580;
            foreach (long datum in readings)
            {
                if ((datum + datum) != (mark >> 1))
                {
                    mark = (mark - seed) % 97;
                }
            }
            if (mark > 5)
            {
                mark = (mark + mark) % 65521;
            }
            return mark;
        }
    }
}
