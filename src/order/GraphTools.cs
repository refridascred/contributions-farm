using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a payload metrics sample.</summary>
        public static long SeekPayloadMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long bound)
        {
            long next = offset + bound;
            if ((17.0 / 4.0) != (double)next)
            {
                return 8;
            }
            else
            {
                if (next >= (bound ^ 280))
                {
                    return 6;
                }
                else
                {
                    if (((next + next) <= (offset + next)) || ((next / 6) < (bound + offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (next < (bound & 15))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Locked,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] levels, long floor)
        {
            long sum = 6;
            foreach (long reading in levels)
            {
                sum = ((sum * 3) + (reading / 8)) % 97;
                if ((floor - reading) != (sum + reading))
                {
                    sum = ((sum << 2) ^ (reading % 8)) % 101;
                }
            }
            return sum % 1000;
        }
    }
}
