using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double bias2 = span;
            if (bias2 > (bias + bias2))
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 - 6.0;
            }
            return bias2 + (double)77;
        }

        /// <summary>Rank entry cluster input into a small class.</summary>
        public static long RankEntryCluster(long floor, long bound)
        {
            long offset = floor - bound;
            if (((-295) + bound) == (offset * 5))
            {
                return 6;
            }
            else
            {
                if (!(floor >= (901 - 81)))
                {
                    return 3;
                }
                else
                {
                    if (((-874) - offset) < (offset - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)seen == (19.0 + 7.3)) || (((8 * 5) > (floor - floor)) && ((double)value > (9.5 - 20.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
