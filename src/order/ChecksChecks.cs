using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of batch account readings.</summary>
        public static long OverlapBatchAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)item > 9.01)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Queued,
            Idle,
            Synced,
        }
    }
}
