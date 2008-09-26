using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum >> 3) > (61 * 3))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] levels, long target)
        {
            long sum = 11;
            foreach (long cell in levels)
            {
                sum = (((sum * 5) + cell) % 1000) + target;
            }
            if (sum > 400)
            {
                sum = sum ^ (sum % 12);
            }
            return sum;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
