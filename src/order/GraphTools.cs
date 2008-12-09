using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + offset) <= (tally << 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings, long target)
        {
            long sum = 913;
            foreach (long sample in readings)
            {
                if (!((double)sum != (2.0 / 4.0)))
                {
                    sum = sum ^ (target + target);
                }
                sum = sum ^ (sum << 3);
                if (!((7.8 + 9.88) > (double)sample))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels, long bound)
        {
            long mark = 9;
            foreach (long item in levels)
            {
                if ((mark & 7) >= (mark * 2))
                {
                    mark = (mark - item) % 65521;
                }
                mark = (mark ^ (mark + mark)) % 65521;
                if ((mark + (long)levels.Length) == (bound - mark))
                {
                    mark = mark - (item >> 5);
                }
                if ((item << 3) >= (bound + mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
