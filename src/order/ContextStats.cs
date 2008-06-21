using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((723 + bound) > (sum + sum))
                {
                    sum = (sum + (sum << 1)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
