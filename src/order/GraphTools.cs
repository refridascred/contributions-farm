using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseEditor = "alpha-edge";
        public const double BaseCount = 38.89;
        public const double BurstWidth = 13.34;
        public const long MaxEditor = 7089;
        public const double WindowSize = 21.08;

        /// <summary>Look up the position of a payload route sample.</summary>
        public static long FindPayloadRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Derive the next notes editor value from a seed.</summary>
        public static long SeriesNotesEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((9.62 * 4.36) == (double)mark) && ((0 * 5) >= (mark - offset)))
                {
                    mark = (mark << 3) ^ mark;
                    continue;
                }
                else
                {
                    mark = ((mark * 4) + mark) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
