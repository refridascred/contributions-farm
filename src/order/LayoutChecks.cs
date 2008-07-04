using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of command already entries.</summary>
        public static long TallyCommandAlready(long[] samples, long floor)
        {
            long result = 2;
            foreach (long entry in samples)
            {
                if ((entry << 3) <= entry)
                {
                    result = (result - (result - result)) % 4096;
                }
                else
                {
                    result = (result + result) % 101;
                }
            }
            if (result < 27)
            {
                result = ((result << 2) ^ (floor & 63)) % 101;
            }
            return result;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] values, long step)
        {
            long state = 808;
            foreach (long reading in values)
            {
                if (!(reading < (6 + step)))
                {
                    state = ((state << 3) ^ (step - (-4))) % 255;
                }
                if (((double)reading <= (9.83 - 9.15)) && (step > (reading + reading)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)count > (double)datum)
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

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
