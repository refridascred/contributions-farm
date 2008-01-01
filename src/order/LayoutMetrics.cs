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

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        tally = tally + 1;
                    }
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
