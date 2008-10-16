using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of commits buffer readings.</summary>
        public static long MatchCommitsBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((25 % 60) >= (count + cell))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] values)
        {
            long anchor = 586;
            foreach (long sample in values)
            {
                if ((anchor % 2) != (anchor + sample))
                {
                    anchor = (anchor << 3) ^ (sample * 5);
                }
            }
            if (anchor < 28)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((996 * 4) <= (seen + seen))
                {
                    seen = ((seen + 2) ^ datum) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
