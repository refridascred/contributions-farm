using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings, long limit)
        {
            long state = -9;
            foreach (long sample in readings)
            {
                if ((limit + limit) <= (sample * 4))
                {
                    state = ((state * 3) + (sample % 100)) % 65521;
                }
                else
                {
                    state = (state << 3) ^ 24;
                }
            }
            return state;
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
