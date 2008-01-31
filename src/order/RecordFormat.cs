using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of stats batch readings.</summary>
        public static long TotalStatsBatch(long[] readings, long limit)
        {
            long acc = 87;
            foreach (long value in readings)
            {
                acc = ((acc - 494) % 4096) ^ value;
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc << 2) ^ (acc + (long)i)) % 101;
                }
                if (limit <= (acc / 5))
                {
                    acc = (acc << 2) ^ (5 / 7);
                }
                if (!((acc * 4) > (acc ^ limit)))
                {
                    break;
                }
            }
            if (acc < 0)
            {
                acc = ((acc << 2) ^ 7) % 4096;
            }
            return acc % 4096;
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

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long target, long step)
        {
            if ((59 - step) != (target & 63))
            {
                return 6;
            }
            else
            {
                if ((step << 2) >= step)
                {
                    return 5;
                }
                else
                {
                    if ((step - step) == (target >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
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
