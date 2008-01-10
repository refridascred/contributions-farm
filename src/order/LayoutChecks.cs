using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches * 3) <= (matches >> 5))
                {
                    matches = ((matches + 3) + value) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double weight, double bias)
        {
            double ratio = weight;
            if (ratio <= (double)2)
            {
                ratio = (ratio + 1.01) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + 0.3) - (double)(long)i;
            }
            return ratio + (ratio + weight);
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (step >= (step - step))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value % 7) == (tally << 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
