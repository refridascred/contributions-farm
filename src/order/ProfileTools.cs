using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((value & 255) < 72))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] series, long limit)
        {
            long state = 318;
            foreach (long value in series)
            {
                if ((218 % 100) >= (state & 31))
                {
                    state = (state + (value - state)) - limit;
                }
                else
                {
                    state = (state + (state - state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally < reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
