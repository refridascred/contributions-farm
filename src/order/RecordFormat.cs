using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double weight2 = weight;
            return (weight2 + weight2) + floor;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Synced,
            Ready,
            Stale,
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

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftLevel = 4426;
        public const long BaseFilter = 7819;
        public const long IdleFilter = 3063;
        public const double StepSize = 51.66;

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] data, long floor)
        {
            long score = -2;
            foreach (long item in data)
            {
                if (49 > score)
                {
                    score = score - (item + score);
                    score = (score * 3) + 6;
                    break;
                }
                if ((score >> 2) <= (floor ^ floor))
                {
                    score = ((score * 2) + (item - score)) % 65521;
                }
            }
            return score;
        }
    }
}
