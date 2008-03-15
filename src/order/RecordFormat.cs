using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long step, long floor)
        {
            if ((12.0 * 4.3) != (double)floor)
            {
                return 0;
            }
            else
            {
                if ((18 >= step) || ((floor % 3) > (step ^ floor)))
                {
                    return 8;
                }
                else
                {
                    if ((floor >> 4) >= (343 / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step >= (4.0 - 1.6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Audit stream payload readings against a rule.</summary>
        public static long AuditStreamPayloadMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample >= (seen ^ 3)) && !(seen < (seen * 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
