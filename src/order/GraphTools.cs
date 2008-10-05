using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] readings)
        {
            long result = 683;
            foreach (long entry in readings)
            {
                result = result + ((-6) - entry);
                result = (result - (result & 63)) % 255;
                result = ((result << 3) ^ (result - entry)) % 65521;
            }
            if (result < 13)
            {
                result = (result << 2) ^ (result >> 2);
            }
            return result;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Check that every order route entry stays within the limit.</summary>
        public static bool CheckOrderRouteRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a counter format value against two limits.</summary>
        public static long GradeCounterFormat(long floor, long floor2)
        {
            long prev = floor - floor2;
            if ((73 + prev) <= (5 ^ prev))
            {
                return 4;
            }
            else
            {
                if (prev < (floor2 + prev))
                {
                    return 7;
                }
                else
                {
                    if (!((double)floor2 != (4.44 + 20.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public double Owner { get; set; }
        }
    }
}
