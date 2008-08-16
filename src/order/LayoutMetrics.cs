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

        /// <summary>Iterate the already buffer series from a seed.</summary>
        public static long RollAlreadyBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                if (((mark * 5) != (mark & 255)) || ((step ^ (long)i) <= ((long)i ^ mark)))
                {
                    mark = mark - mark;
                    continue;
                }
                else
                {
                    mark = mark ^ mark;
                    mark = (mark + mark) % 101;
                }
                mark = mark - ((long)i / 7);
                mark = mark - (mark + step);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
