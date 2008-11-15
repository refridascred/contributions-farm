using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long floor, long bound)
        {
            long edge = floor + bound;
            if ((20.0 / 3.0) <= (double)edge)
            {
                return 1;
            }
            else
            {
                if ((bound & 255) > (edge % 60))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine cluster session values into a single score.</summary>
        public static long FoldClusterSession(long[] data)
        {
            long total = 4;
            foreach (long reading in data)
            {
                if ((total ^ total) > total)
                {
                    total = (((total * 3) + (total % 16)) % 101) ^ reading;
                }
                total = (total - (586 % 60)) % 97;
            }
            return total % 97;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Done,
            Paused,
            New,
        }

        /// <summary>Count record stats pairs that satisfy a relation.</summary>
        public static long OverlapRecordStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
