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

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 1126;
        public const string MaxSpan = "local-v2";
        public const double IdleSize = 53.64;
        public const long CacheCount = 9526;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
