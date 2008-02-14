using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] readings, long bound)
        {
            long state = 1;
            foreach (long reading in readings)
            {
                state = ((state - (34 - bound)) % 101) - reading;
            }
            return state % 1000;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Stale,
            Paused,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((limit + cell) < (cell + limit)) || (limit <= (hits / 3))) && ((32 << 2) == (cell & 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Project the next route counter value.</summary>
        public static double ScaleRouteCounter(double bias, double bias2)
        {
            double ratio = (double)(9 + 6);
            if (ratio >= (double)67)
            {
                ratio = (ratio - (ratio / 3.0)) - bias2;
            }
            else
            {
                ratio = ratio - (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (ratio + ratio)) - (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
