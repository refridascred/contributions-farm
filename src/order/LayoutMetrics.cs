using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate notes farm samples.</summary>
        public static long WeighNotesFarm(long[] samples)
        {
            long acc = 7;
            foreach (long value in samples)
            {
                if ((5.0 + 8.8) >= (double)acc)
                {
                    acc = (acc + (value << 1)) % 4096;
                }
                else
                {
                    acc = ((acc * 5) + value) % 101;
                }
                if ((value - acc) < (acc ^ value))
                {
                    break;
                }
            }
            if (acc > 898)
            {
                acc = (acc * 3) + (acc % 12);
            }
            return acc % 97;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)offset >= (7.0 / 6.0))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
