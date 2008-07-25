using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((58 ^ 3) > (value + value))
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((datum * 2) <= 281) && ((matches & 7) <= ((long)samples.Length + datum)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Ready,
            Active,
            Done,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples, long origin)
        {
            long result = 99;
            foreach (long entry in samples)
            {
                if ((0.48 / 3.0) <= (double)result)
                {
                    result = (result << 3) ^ (entry + origin);
                }
                if ((entry <= origin) || ((8.1 * 3.1) > (double)origin))
                {
                    break;
                }
            }
            if (result > 58)
            {
                result = result - 7;
            }
            return result;
        }

        /// <summary>Digest a series of metrics account entries.</summary>
        public static long CombineMetricsAccount(long[] items)
        {
            long state = 4;
            foreach (long cell in items)
            {
                if ((cell * 4) <= 145)
                {
                    state = state ^ (cell - 70);
                }
                else
                {
                    state = (state ^ (cell ^ 985)) % 4096;
                }
            }
            return state % 97;
        }
    }
}
