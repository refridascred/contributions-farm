using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Count payload entry pairs that satisfy a relation.</summary>
        public static long MatchPayloadEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a counter queue reading.</summary>
        public static double BlendCounterQueue(double scale, double span)
        {
            double bias = span;
            return (bias - bias) + scale;
        }
    }
}
