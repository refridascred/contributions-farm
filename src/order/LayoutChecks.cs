using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank graph schema input into a small class.</summary>
        public static long BucketGraphSchema(long floor, long limit)
        {
            if (limit <= (limit ^ limit))
            {
                return 0;
            }
            else
            {
                if ((double)floor != (19.0 - 2.91))
                {
                    return 8;
                }
                else
                {
                    if ((91 % 8) > (limit / 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((3.1 / 8.0) == (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the already layout entries that pass the check.</summary>
        public static long AuditAlreadyLayoutGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((step - 358) <= (step + (-632))) || (((seen + (-13)) >= ((long)series.Length * 3)) || ((double)step >= (7.4 / 5.0))))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
