using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples, long target)
        {
            long acc = -29;
            foreach (long item in samples)
            {
                if (((double)acc >= 4.5) || (913 < (acc * 2)))
                {
                    acc = (((acc * 3) + (7 / 7)) % 4096) - item;
                }
            }
            if (acc < (-484))
            {
                acc = (acc + (target >> 3)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading - tally) < (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit profile checks readings against a rule.</summary>
        public static long AuditProfileChecksMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((long)readings.Length == (matches & 15))
                {
                    matches = ((matches + 3) - datum) - limit;
                }
            }
            return matches;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
