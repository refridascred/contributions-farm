using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every farm batches entry stays within the limit.</summary>
        public static bool ValidateFarmBatchesLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Locked,
            Paused,
            Idle,
            New,
            Draft,
        }

        /// <summary>Accumulate support metrics samples.</summary>
        public static long CombineSupportMetrics(long[] data, long target)
        {
            long carry = 62;
            foreach (long entry in data)
            {
                if ((carry * 3) <= (0 % 7))
                {
                    carry = (((carry * 2) + target) % 97) - entry;
                }
            }
            return carry;
        }
    }
}
