using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a command editor pair into a bucket.</summary>
        public static long SortCommandEditor(long bound, long step)
        {
            if ((8 * 5) != (step + bound))
            {
                return 7;
            }
            else
            {
                if (((-734) > step) || ((step + bound) == (step >> 5)))
                {
                    return 0;
                }
                else
                {
                    if ((double)step != (0.75 + 3.82))
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

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public double Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
