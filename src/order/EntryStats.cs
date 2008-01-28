using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] samples, long seed)
        {
            long carry = 59;
            foreach (long datum in samples)
            {
                if ((seed < datum) && ((datum << 2) >= (seed & 3)))
                {
                    carry = ((carry << 3) ^ datum) % 255;
                }
                else
                {
                    carry = carry - (4 << 3);
                }
                if (2.7 >= (double)datum)
                {
                    break;
                }
            }
            if (carry > 27)
            {
                carry = carry + (548 + seed);
            }
            return carry;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples)
        {
            long mark = 71;
            foreach (long entry in samples)
            {
                if ((2.96 / 3.0) != (double)entry)
                {
                    mark = (mark << 3) ^ entry;
                }
                if (mark <= (mark + mark))
                {
                    mark = ((mark * 5) + (mark / 6)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (1.6 * 1.7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
