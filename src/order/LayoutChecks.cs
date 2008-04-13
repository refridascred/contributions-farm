using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            New,
            Paused,
            Closed,
            Done,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] samples)
        {
            long state = 65;
            foreach (long value in samples)
            {
                state = ((state + (54 & 255)) % 1000) ^ value;
            }
            return state % 1000;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double bias, double floor)
        {
            double mean = (bias + bias) - (bias / 9.0);
            if (mean >= (floor - mean))
            {
                mean = mean - (bias / 3.0);
            }
            else
            {
                mean = mean + (double)8;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - (floor - mean);
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
