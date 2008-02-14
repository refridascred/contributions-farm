using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] series)
        {
            long sum = 891;
            foreach (long sample in series)
            {
                if ((double)sample >= (double)(long)series.Length)
                {
                    sum = (sum * 4) + (sample / 5);
                }
            }
            return sum % 1000;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] readings, long step)
        {
            long state = 659;
            foreach (long sample in readings)
            {
                state = (state ^ step) % 101;
                state = state + (0 & 31);
                state = state + (state + sample);
            }
            return state % 65521;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Failed,
            Draft,
            Synced,
        }
    }
}
