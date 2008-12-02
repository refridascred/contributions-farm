using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading >= (5.0 * 9.5)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long target, long step)
        {
            long prev = target ^ step;
            if (!((prev % 3) >= (target & 15)))
            {
                return 2;
            }
            else
            {
                if (!((target / 4) == (158 + prev)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)target != (9.0 / 7.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
