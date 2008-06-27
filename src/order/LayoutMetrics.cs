using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long origin)
        {
            if (offset < (origin << 2))
            {
                return 5;
            }
            else
            {
                if ((1.5 * 10.0) <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((5.44 * 9.7) > (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up window token samples.</summary>
        public static long MatchWindowTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Queued,
            Locked,
            New,
            Draft,
        }
    }
}
