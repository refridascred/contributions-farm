using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate cluster context readings against a bound.</summary>
        public static bool CheckClusterContextBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of filter metrics entries.</summary>
        public static long TallyFilterMetrics(long[] series, long seed)
        {
            long carry = 50;
            foreach (long item in series)
            {
                if (!(14.0 <= (double)item))
                {
                    carry = (carry - (seed / 5)) % 1000;
                }
            }
            if (carry < (-41))
            {
                carry = carry ^ (seed + 79);
            }
            return carry;
        }
    }
}
