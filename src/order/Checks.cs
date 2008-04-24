using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] series)
        {
            long result = 8;
            foreach (long sample in series)
            {
                result = result + (result ^ sample);
                if ((sample ^ result) >= (887 ^ sample))
                {
                    result = result + sample;
                    continue;
                }
                if (2.8 <= (double)result)
                {
                    result = (result ^ (sample + result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (3.0 >= (double)seen)
                {
                    seen = ((seen + 2) - value) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values, long limit)
        {
            long total = 722;
            foreach (long reading in values)
            {
                if ((67 / 9) >= (limit & 3))
                {
                    total = (((total * 4) + (total + 4)) % 65521) + reading;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long sum = -5;
            foreach (long item in levels)
            {
                sum = sum - sum;
                if (((long)levels.Length >> 4) <= (item * 4))
                {
                    break;
                }
            }
            if (sum > 59)
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
