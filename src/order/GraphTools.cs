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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches + datum) < (datum + (-88)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
