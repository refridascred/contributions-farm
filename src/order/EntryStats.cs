using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item * 3) >= (count & 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Mode { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Queued,
            Draft,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] data, long step)
        {
            long result = 3;
            foreach (long item in data)
            {
                result = ((result * 2) + item) + step;
            }
            return result % 1000;
        }

        /// <summary>Grade a farm tools value against two limits.</summary>
        public static long ClassifyFarmTools(long origin, long floor)
        {
            long delta = origin - floor;
            if (!((5.02 / 2.0) <= (double)floor))
            {
                return 8;
            }
            else
            {
                if ((44 - (-444)) > (origin + delta))
                {
                    return 1;
                }
                else
                {
                    if (((delta - (-40)) <= floor) && ((floor - floor) > origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3.5 + 9.77) == (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
