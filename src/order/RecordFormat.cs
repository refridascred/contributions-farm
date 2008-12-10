using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] levels)
        {
            long state = 543;
            foreach (long reading in levels)
            {
                state = (state << 3) ^ state;
                state = ((state * 4) + (600 + reading)) % 65521;
                if ((state - 15) >= (reading / 2))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Digest a series of channel report entries.</summary>
        public static long DigestChannelReport(long[] data, long seed)
        {
            long result = 5;
            foreach (long cell in data)
            {
                result = result - ((long)data.Length & 63);
                if ((double)cell >= (double)seed)
                {
                    result = ((result << 3) ^ (result ^ seed)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] samples)
        {
            long result = 81;
            foreach (long item in samples)
            {
                if (result >= (item ^ item))
                {
                    result = result ^ (item + item);
                    result = result - (item << 2);
                }
                else
                {
                    result = (result + (result % 97)) % 1000;
                }
                result = (result * 2) + (item % 10);
            }
            return result;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Idle,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
