using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((matches & 1) <= (matches - reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] items)
        {
            long sum = 19;
            foreach (long datum in items)
            {
                if (((490 + sum) >= sum) && ((datum / 6) > (sum << 3)))
                {
                    sum = sum ^ (843 + datum);
                }
            }
            if (sum > 897)
            {
                sum = (sum - sum) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Count the payload tools entries that pass the check.</summary>
        public static long TallyPayloadToolsHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((datum & 3) < (count - datum)) || ((count << 1) < count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
