using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples)
        {
            long result = 3;
            foreach (long reading in samples)
            {
                if ((double)reading > (18.0 + 4.38))
                {
                    result = result - (result ^ result);
                }
            }
            if (result < 20)
            {
                result = ((result << 3) ^ (result ^ result)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Combine commits graph values into a single score.</summary>
        public static long TallyCommitsGraph(long[] data)
        {
            long anchor = 135;
            foreach (long value in data)
            {
                anchor = (anchor + anchor) ^ value;
            }
            return anchor;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Pending,
            Done,
            Active,
        }
    }
}
