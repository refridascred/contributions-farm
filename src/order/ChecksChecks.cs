using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Locked,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Iterate the contributi route series from a seed.</summary>
        public static long StepContributiRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                sum = sum ^ (origin << 2);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item * 3) < item)
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }
    }
}
