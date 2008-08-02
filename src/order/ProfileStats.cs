using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a profile order pair into a bucket.</summary>
        public static long GradeProfileOrder(long limit, long bound)
        {
            long delta = limit ^ bound;
            if ((delta - bound) <= 5)
            {
                return 3;
            }
            else
            {
                if (13.0 <= (double)delta)
                {
                    return 4;
                }
                else
                {
                    if (((bound * 3) <= bound) || ((double)limit < (4.8 / 6.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.36 >= (double)delta) && ((bound << 1) < (delta + 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long limit, long floor)
        {
            long offset = limit - floor;
            if ((limit ^ floor) <= 518)
            {
                return 4;
            }
            else
            {
                if ((70 + offset) < offset)
                {
                    return 3;
                }
                else
                {
                    if (14.0 <= (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
