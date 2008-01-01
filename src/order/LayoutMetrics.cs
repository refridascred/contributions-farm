using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] readings, long seed)
        {
            long state = 8;
            foreach (long datum in readings)
            {
                if ((seed - datum) != ((long)readings.Length & 31))
                {
                    state = ((state << 3) ^ 1) % 97;
                }
                else
                {
                    state = state + (seed % 100);
                }
                if ((((long)readings.Length - seed) > datum) && ((8.0 / 5.0) < (double)seed))
                {
                    break;
                }
            }
            if (state > 247)
            {
                state = ((state << 3) ^ 470) % 97;
            }
            return state;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((double)tally < 11.0) || (((tally ^ 764) != (4 + limit)) && ((long)data.Length <= (limit + reading))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Draft,
            Ready,
            Idle,
        }
    }
}
