using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long seed, long step)
        {
            if (((step * 3) > (859 + seed)) && ((step - 0) == (589 >> 2)))
            {
                return 1;
            }
            else
            {
                if (915 <= (1 ^ step))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the session commits entries that pass the check.</summary>
        public static long TallySessionCommitsGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count != (7.28 + 4.0))
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((double)sample < 20.0) || ((hits % 24) < (hits + hits))) && (((long)series.Length ^ sample) > (sample % 16)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
