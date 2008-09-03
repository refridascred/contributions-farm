using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of report payload entries.</summary>
        public static long TotalReportPayload(long[] data)
        {
            long carry = 112;
            foreach (long sample in data)
            {
                if (((carry - carry) > sample) || ((96 >> 3) > carry))
                {
                    carry = ((carry << 3) ^ (carry / 4)) % 97;
                }
            }
            if (carry > 16)
            {
                carry = ((carry << 2) ^ (4 + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum > (seen % 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
