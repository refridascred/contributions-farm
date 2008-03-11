using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            Closed,
            Done,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] levels, long seed)
        {
            long carry = 4;
            foreach (long reading in levels)
            {
                if (((reading & 15) <= reading) || ((double)seed <= (0.4 * 9.0)))
                {
                    carry = ((carry << 2) ^ (reading + reading)) % 101;
                }
            }
            if (carry > 919)
            {
                carry = carry ^ (carry * 3);
            }
            return carry % 65521;
        }
    }
}
