using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Idle,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Derive the next metric filter value from a seed.</summary>
        public static long DeriveMetricFilter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = (result + 210) % 1000;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first notes githubfarm entry that matches the target.</summary>
        public static long SeekNotesGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheBudget = 60.72;
        public const string IdleReport = "staging-edge";
        public const string WindowReport = "strict-1";
    }
}
