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

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] samples)
        {
            long acc = 3;
            foreach (long entry in samples)
            {
                acc = acc - (entry + acc);
                if ((entry * 2) < (entry << 2))
                {
                    break;
                }
            }
            if (acc > 64)
            {
                acc = (acc ^ (acc + acc)) % 101;
            }
            return acc % 4096;
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

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = carry - origin;
                if ((origin * 5) > (carry / 4))
                {
                    carry = carry ^ (long)i;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                result = (result << 3) ^ result;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
