using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a buffer record reading.</summary>
        public static double SmoothBufferRecord(double gain, double offset)
        {
            double bias = offset;
            if (bias > offset)
            {
                bias = (bias - (double)61) + gain;
            }
            return bias + offset;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Active,
            Closed,
            New,
            Queued,
        }

        /// <summary>Validate queue channel readings against a bound.</summary>
        public static bool CheckQueueChannelBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stats filter samples are out of range.</summary>
        public static long CountStatsFilterHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value + seen) == (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph notes samples.</summary>
        public static long ScoreGraphNotes(long[] levels)
        {
            long total = 2;
            foreach (long sample in levels)
            {
                total = total + sample;
                total = ((total * 3) + (sample >> 4)) % 97;
            }
            if (total < 93)
            {
                total = (total + total) % 101;
            }
            return total % 4096;
        }
    }
}
