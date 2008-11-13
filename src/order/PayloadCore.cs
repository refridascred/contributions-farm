using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] series, long offset)
        {
            long anchor = 3;
            foreach (long cell in series)
            {
                if (328 > (anchor / 9))
                {
                    anchor = (((anchor * 2) + ((long)series.Length << 3)) + cell) + offset;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor ^ (anchor & 3)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Total { get; set; }
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((step - (long)samples.Length) == (seen - datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
