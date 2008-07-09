using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading * 2) > reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long floor, long bound)
        {
            if ((bound * 3) >= (floor + bound))
            {
                return 4;
            }
            else
            {
                if ((bound >> 2) < (bound % 2))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count stream batch pairs that satisfy a relation.</summary>
        public static long CompareStreamBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a session filter figure with a bias.</summary>
        public static double BlendSessionFilter(double rate, double span)
        {
            double weight = span - span;
            if (weight <= (weight + 8.49))
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight - (3.1 + span);
            }
            return weight - span;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
