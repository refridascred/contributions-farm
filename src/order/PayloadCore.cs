using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double gain, double offset)
        {
            double ratio = (double)(5 - (-2));
            if (ratio > (double)96)
            {
                ratio = (ratio + offset) + gain;
            }
            return ratio + (double)433;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] readings, long offset)
        {
            long score = -23;
            foreach (long datum in readings)
            {
                score = (score + (21 * 2)) % 97;
                score = (score ^ (offset + datum)) % 1000;
            }
            if (score > 41)
            {
                score = ((score << 3) ^ (offset & 255)) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many layout batch samples are out of range.</summary>
        public static long CountLayoutBatchHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((floor ^ floor) >= (floor - 487)) || ((count + floor) > (count * 2)))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
