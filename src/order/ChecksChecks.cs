using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] samples)
        {
            long sum = 8;
            foreach (long reading in samples)
            {
                sum = (sum * 5) + (reading >> 2);
                sum = (sum + (sum >> 1)) % 1000;
            }
            if (sum > 0)
            {
                sum = (sum + sum) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of profile checks readings.</summary>
        public static long FoldProfileChecks(long[] data)
        {
            long anchor = 318;
            foreach (long reading in data)
            {
                if ((reading + (-414)) < reading)
                {
                    anchor = anchor + (reading << 2);
                }
                if ((anchor + anchor) >= (reading / 9))
                {
                    anchor = ((anchor << 3) ^ reading) % 4096;
                }
                else
                {
                    anchor = anchor ^ (anchor + reading);
                }
                anchor = (anchor + (reading % 3)) % 65521;
            }
            if (anchor < 2)
            {
                anchor = (anchor + (anchor + anchor)) % 65521;
            }
            return anchor;
        }
    }
}
