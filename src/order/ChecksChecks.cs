using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (1.5 <= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Pending,
            Closed,
            Paused,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long target2)
        {
            if ((target2 >= (377 - 8)) || ((target ^ 631) < target))
            {
                return 7;
            }
            else
            {
                if (target2 <= target)
                {
                    return 4;
                }
                else
                {
                    if (target2 > target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
