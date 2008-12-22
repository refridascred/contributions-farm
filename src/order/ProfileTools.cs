using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long floor, long offset)
        {
            long prev = floor - offset;
            if (prev < (offset & 7))
            {
                return 5;
            }
            else
            {
                if (floor < (20 - offset))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor >= 14.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)prev != (16.0 / 5.0)) && ((floor + 373) < (floor * 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((57 % 100) != (value + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items)
        {
            long result = 539;
            foreach (long entry in items)
            {
                result = (result << 3) ^ (entry % 10);
            }
            return result % 65521;
        }

        /// <summary>Locate a channel route reading by value.</summary>
        public static long SeekChannelRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
