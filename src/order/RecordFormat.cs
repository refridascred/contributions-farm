using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples, long offset)
        {
            long total = 3;
            foreach (long cell in samples)
            {
                if (!((offset % 60) != (cell - total)))
                {
                    total = (total ^ (offset << 2)) % 65521;
                }
            }
            return total;
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
