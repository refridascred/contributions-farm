using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string StepDepth = "legacy-edge";
        public const long IdleLevel = 8315;
        public const string CacheTimeout = "staging-edge";

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample + sample) != (sample << 1)) && ((sample % 3) != (sample + (long)values.Length)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Idle,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Match up window tools samples.</summary>
        public static long MatchWindowToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
