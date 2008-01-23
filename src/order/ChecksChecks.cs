using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Closed,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - mark) % 4096;
                if ((limit - limit) <= (limit << 3))
                {
                    mark = (mark - (mark / 4)) % 97;
                }
                else
                {
                    mark = mark - limit;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
