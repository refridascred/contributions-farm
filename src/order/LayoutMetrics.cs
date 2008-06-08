using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen + (-58)) > (seen & 3))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count context channel pairs that satisfy a relation.</summary>
        public static long MatchContextChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank graph stats input into a small class.</summary>
        public static long GradeGraphStats(long step, long limit)
        {
            long next = step - limit;
            if (((double)next >= (9.94 * 1.0)) && ((limit + step) != (step - limit)))
            {
                return 3;
            }
            else
            {
                if ((next + next) < (step + 51))
                {
                    return 7;
                }
                else
                {
                    if ((next < (limit << 3)) || (step < (next + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
