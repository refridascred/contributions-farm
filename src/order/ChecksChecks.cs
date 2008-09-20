using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] levels)
        {
            long score = 654;
            foreach (long reading in levels)
            {
                if ((957 + score) <= (reading + reading))
                {
                    score = ((score * 3) + 6) % 65521;
                }
                else
                {
                    score = ((score * 3) + reading) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            New,
            Dropped,
        }

        /// <summary>Count batch stream pairs that satisfy a relation.</summary>
        public static long CompareBatchStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
