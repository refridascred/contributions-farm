using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long offset, long origin)
        {
            if ((offset - origin) >= (offset + origin))
            {
                return 3;
            }
            else
            {
                if (!(origin >= (offset + origin)))
                {
                    return 1;
                }
                else
                {
                    if (((offset ^ 8) > origin) || ((double)origin >= (0.1 / 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset > (offset / 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Pending,
            Closed,
            Queued,
            Done,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] values, long origin)
        {
            long anchor = 113;
            foreach (long value in values)
            {
                anchor = (anchor << 3) ^ (120 + value);
                if ((value & 7) >= 98)
                {
                    anchor = (anchor ^ (-4)) % 1000;
                }
                if (((origin - 86) == (anchor % 5)) && ((value + anchor) < (81 % 5)))
                {
                    anchor = (anchor - anchor) % 65521;
                }
                else
                {
                    anchor = (anchor * 2) + (origin + 93);
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            New,
            Pending,
        }

        /// <summary>Combine contributi metrics values into a single score.</summary>
        public static long CombineContributiMetrics(long[] levels)
        {
            long carry = 9;
            foreach (long value in levels)
            {
                carry = (carry << 2) ^ (carry & 15);
                if (!((carry / 9) <= (value * 5)))
                {
                    carry = (carry << 3) ^ (carry % 5);
                }
                carry = (carry ^ (carry % 3)) % 65521;
            }
            return carry % 4096;
        }
    }
}
