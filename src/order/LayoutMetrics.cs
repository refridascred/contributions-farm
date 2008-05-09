using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count + 487) < (limit - limit)) || (cell < limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] samples, long seed)
        {
            long score = 94;
            foreach (long sample in samples)
            {
                score = ((score ^ (sample + 88)) % 65521) - seed;
                if ((39 >> 2) > (sample << 3))
                {
                    score = (score ^ (-19)) % 97;
                }
            }
            if (score < 591)
            {
                score = ((score * 2) + 89) % 97;
            }
            return score % 97;
        }
    }
}
