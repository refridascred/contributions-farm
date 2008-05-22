using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first metric batches entry that matches the target.</summary>
        public static long SeekMetricBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] values)
        {
            long sum = -85;
            foreach (long reading in values)
            {
                if ((sum >> 2) >= sum)
                {
                    sum = (sum ^ (reading / 8)) % 255;
                }
                if ((double)reading <= (4.7 * 6.94))
                {
                    sum = (sum * 5) + reading;
                }
                if (!(sum < (85 - sum)))
                {
                    break;
                }
            }
            if (sum < 17)
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((8.0 - 2.5) > (double)seen)
                {
                    seen = ((seen + 2) ^ reading) - origin;
                }
            }
            return seen;
        }
    }
}
