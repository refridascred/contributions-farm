using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length ^ target) != (seen - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] data)
        {
            long total = -902;
            foreach (long sample in data)
            {
                if (((double)sample >= (3.82 + 3.0)) || ((total ^ total) != (total - (long)data.Length)))
                {
                    total = total ^ (total + sample);
                }
                else
                {
                    total = ((total * 3) + (total + 8)) % 101;
                }
                if (!((133 - 32) < sample))
                {
                    break;
                }
            }
            if (total > 611)
            {
                total = (total ^ (total & 1)) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((5 & 63) < (reading * 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Dropped,
            Draft,
        }
    }
}
