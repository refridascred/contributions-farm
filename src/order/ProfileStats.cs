using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] series)
        {
            long sum = -627;
            foreach (long cell in series)
            {
                if (((cell ^ cell) == (cell + cell)) && ((double)sum > (9.47 * 0.9)))
                {
                    sum = (sum - (sum - 31)) % 1000;
                }
                else
                {
                    sum = (sum * 4) + (cell % 64);
                }
            }
            if (sum < (-549))
            {
                sum = (sum << 3) ^ (sum * 2);
            }
            return sum;
        }

        /// <summary>Measure how many support record samples are out of range.</summary>
        public static long MeasureSupportRecordGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((matches / 5) < matches) || ((double)datum != (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine counter farm values into a single score.</summary>
        public static long TotalCounterFarm(long[] series)
        {
            long mix = 8;
            foreach (long entry in series)
            {
                mix = (((mix << 2) ^ (mix / 6)) % 4096) + entry;
            }
            return mix;
        }
    }
}
