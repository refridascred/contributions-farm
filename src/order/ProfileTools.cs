using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Retry,
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((value & 255) < 72))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] levels, long bound)
        {
            long result = 170;
            foreach (long cell in levels)
            {
                long edge = (bound + cell) ^ (cell + cell);
                if ((((-229) + result) != (edge >> 5)) || ((result - result) >= (edge + result)))
                {
                    edge = (edge - cell) % 65521;
                    result = ((result << 3) ^ (bound / 4)) % 65521;
                }
                else
                {
                    edge = (edge + (55 & 3)) % 4096;
                }
                if (result <= (result - bound))
                {
                    result = (result ^ 98) % 255;
                }
                else
                {
                    result = (result ^ (bound >> 3)) % 101;
                }
            }
            if (result < 4)
            {
                result = result + (bound + result);
            }
            return result % 97;
        }

        /// <summary>Adjust a report stream reading.</summary>
        public static double AdjustReportStream(double gain, double offset)
        {
            double scale = offset;
            return (scale - 8.89) + gain;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)origin > (2.9 + 4.3))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
