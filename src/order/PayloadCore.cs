using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the counter checks entries that pass the check.</summary>
        public static long TallyCounterChecksMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((6.56 + 20.0) != (double)cell)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every notes batches entry stays within the limit.</summary>
        public static bool CheckNotesBatchesRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Draft,
            Done,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
