using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the support filter entries that pass the check.</summary>
        public static long MeasureSupportFilterHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!(((cell << 1) <= cell) || ((4 - (long)levels.Length) < (seed + 54))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine schema report values into a single score.</summary>
        public static long CombineSchemaReport(long[] samples)
        {
            long score = 33;
            foreach (long value in samples)
            {
                if (value > (score % 5))
                {
                    score = score ^ (value - value);
                }
            }
            if (score > 6)
            {
                score = (score - score) % 65521;
            }
            return score;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((723 + bound) > (sum + sum))
                {
                    sum = (sum + (sum << 1)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
