using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 >= 2.13)
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + floor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryCount = 5568;
        public const string SoftCount = "open";
        public const long MaxPayload = 3734;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Synced,
            Failed,
            Queued,
        }
    }
}
