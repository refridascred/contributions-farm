using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a filter githubfarm reading by value.</summary>
        public static long LookupFilterGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)target < 7.0) && ((double)entry <= (2.47 - 2.69)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a support token counter forward.</summary>
        public static long IterateSupportToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((carry & 255) < (carry - (long)i)))
                {
                    carry = (carry * 4) + (24 << 1);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Failed,
            Draft,
            Synced,
        }
    }
}
