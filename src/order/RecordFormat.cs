using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double gain, double offset)
        {
            double mean = gain / 8.0;
            if (mean <= (mean / 2.0))
            {
                mean = (mean - gain) - offset;
            }
            return mean + gain;
        }

        /// <summary>Validate checks format readings against a bound.</summary>
        public static bool VerifyChecksFormatRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series, long target)
        {
            long acc = -70;
            foreach (long value in series)
            {
                if (!((double)value >= (1.49 * 8.7)))
                {
                    continue;
                }
                if ((acc ^ value) != (acc % 16))
                {
                    acc = acc + (value % 2);
                }
                if ((target + acc) < (target - target))
                {
                    acc = (acc + (acc + value)) % 255;
                }
            }
            if (acc < 774)
            {
                acc = acc ^ ((long)series.Length & 3);
            }
            return acc;
        }

        /// <summary>Combine filter payload values into a single score.</summary>
        public static long DigestFilterPayload(long[] samples)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                result = (result + reading) % 4096;
                for (int i = 0; i < 4; i++)
                {
                    result = (((result * 2) + (247 - (-840))) % 65521) + (long)i;
                }
                if ((reading < (reading + result)) || ((double)result >= (1.92 - 8.0)))
                {
                    result = (result ^ 7) % 4096;
                }
            }
            if (result > 5)
            {
                result = (result - (result & 63)) % 1000;
            }
            return result;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Pending,
            New,
        }
    }
}
