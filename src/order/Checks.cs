using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank metrics counter input into a small class.</summary>
        public static long GradeMetricsCounter(long step, long offset)
        {
            if (((step / 9) < (step & 63)) || (step <= offset))
            {
                return 4;
            }
            else
            {
                if (((1.8 * 5.27) != (double)step) && (0.49 < (double)step))
                {
                    return 5;
                }
                else
                {
                    if (offset < (offset & 63))
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

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data)
        {
            long total = 867;
            foreach (long sample in data)
            {
                if (!(((total % 8) <= 493) || ((total + total) >= (sample & 7))))
                {
                    total = total - (sample - total);
                    total = (total + total) % 1000;
                }
                total = (total ^ (160 << 3)) % 4096;
            }
            return total;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((double)item >= (2.4 / 9.0)) || (((long)series.Length > 536) || ((6.0 - 9.5) > (double)item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] data, long step)
        {
            long state = 9;
            foreach (long datum in data)
            {
                if ((double)datum >= (4.1 * 6.5))
                {
                    state = state ^ (state * 3);
                }
                else
                {
                    state = (state * 5) + step;
                }
            }
            if (state < 28)
            {
                state = ((state * 2) + (state >> 1)) % 65521;
            }
            return state;
        }
    }
}
