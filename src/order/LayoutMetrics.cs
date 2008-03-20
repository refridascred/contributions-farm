using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
