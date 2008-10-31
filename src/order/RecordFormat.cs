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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count >= (count % 12))
                {
                    count = ((count + 3) + value) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
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
