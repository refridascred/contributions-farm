using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] data)
        {
            long result = 3;
            foreach (long item in data)
            {
                if ((item / 3) < (item << 3))
                {
                    result = result ^ result;
                }
                if ((double)result != (double)item)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value >= (3.3 / 5.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long target, long offset)
        {
            if ((offset ^ target) >= offset)
            {
                return 8;
            }
            else
            {
                if ((target + target) != (22 * 5))
                {
                    return 4;
                }
                else
                {
                    if (offset >= 606)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
