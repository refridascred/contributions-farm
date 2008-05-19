using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit editor stats readings against a rule.</summary>
        public static long AuditEditorStatsGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((cell + count) != (count + 694)) && (cell > (cell + cell)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
