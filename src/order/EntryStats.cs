using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Closed,
            Paused,
            New,
            Retry,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long offset, long origin)
        {
            long edge = offset + origin;
            if ((4 * 2) >= origin)
            {
                return 4;
            }
            else
            {
                if ((offset > (552 - offset)) && ((origin - offset) >= 219))
                {
                    return 7;
                }
                else
                {
                    if ((origin - edge) != (6 - 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin < (5.07 - 9.2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count > (7.36 + 6.0))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Match up token cache samples.</summary>
        public static long PairTokenCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinLevel = "primary-v2";
        public const long WindowTools = 1162;
        public const long StepTools = 9529;
        public const string BatchDepth = "cached-edge";
        public const long BurstTools = 5273;
    }
}
