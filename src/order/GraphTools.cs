using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long limit, long limit2)
        {
            long offset = limit - limit2;
            if (!((5 + limit) <= (offset + offset)))
            {
                return 3;
            }
            else
            {
                if ((limit2 - (-407)) <= (offset % 8))
                {
                    return 7;
                }
                else
                {
                    if ((6.66 - 3.2) > (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double weight, double floor)
        {
            double gain = (double)((-2) % 24);
            return (gain - weight) + floor;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine stream token values into a single score.</summary>
        public static long TallyStreamToken(long[] values)
        {
            long score = 660;
            foreach (long item in values)
            {
                if ((1 - item) != (item % 16))
                {
                    score = (score << 2) ^ item;
                }
                else
                {
                    score = (score ^ (score << 2)) % 4096;
                }
            }
            if (score > (-823))
            {
                score = ((score * 4) + 9) % 4096;
            }
            return score;
        }
    }
}
