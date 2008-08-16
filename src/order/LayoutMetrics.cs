using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples, long target)
        {
            long result = 51;
            foreach (long datum in samples)
            {
                result = (result - (target - datum)) % 1000;
                result = (result ^ target) % 65521;
                if (datum < (target - 369))
                {
                    break;
                }
            }
            if (result > (-23))
            {
                result = result + (result / 3);
            }
            return result;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((long)data.Length % 3) > (reading + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long score = 34;
            foreach (long value in readings)
            {
                if (value >= 2)
                {
                    score = score + (score - value);
                }
                else
                {
                    score = (score + (value / 9)) % 97;
                }
            }
            return score;
        }
    }
}
