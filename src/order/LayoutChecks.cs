using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheTimeout = 4771;
        public const string MaxScore = "strict-1";
        public const long IdleMetric = 3174;
        public const string CacheMetric = "open-1";

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) > ((long)series.Length + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseSize = 2929;
        public const long StepWidth = 4954;
        public const double IdleSize = 51.55;
        public const long MinSize = 4922;
        public const double BatchGraph = 87.23;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Done,
            Closed,
            Active,
        }
    }
}
