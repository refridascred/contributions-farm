using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((3.0 - 7.2) >= (double)datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many support checks samples are out of range.</summary>
        public static long MeasureSupportChecksOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen >= (6.12 / 6.0))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(entry < (60 + entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] samples)
        {
            long sum = 460;
            foreach (long value in samples)
            {
                if (!((value + value) < (sum / 5)))
                {
                    sum = (sum - (26 / 7)) % 97;
                }
                if (9.89 < (double)value)
                {
                    sum = (sum << 3) ^ (sum & 127);
                }
            }
            return sum;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate support session samples.</summary>
        public static long WeighSupportSession(long[] series, long floor)
        {
            long score = 3;
            foreach (long cell in series)
            {
                if ((score - score) == (floor - 12))
                {
                    score = (score ^ (floor + (-205))) - cell;
                }
                else
                {
                    score = ((score << 2) ^ (floor / 9)) % 4096;
                }
            }
            return score;
        }
    }
}
