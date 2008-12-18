using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the checks channel entries that pass the check.</summary>
        public static long MeasureChecksChannelMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((53 + datum) > (hits - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
